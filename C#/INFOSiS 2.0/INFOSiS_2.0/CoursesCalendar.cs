using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace INFOSiS_2._0
{
    public partial class CoursesCalendar : UserControl
    {
        private static CoursesCalendar _instance;
        private static Panel _panelMdi;
        private Server.ServerClient server;

        public CoursesCalendar()
        {
            InitializeComponent();
            dtpDesde.Value = DateTime.Today;
            actualizar_calendario();
        }

        public static CoursesCalendar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CoursesCalendar();
                return _instance;
            }
        }

        public static Panel PanelMdi { get => _panelMdi; set => _panelMdi = value; }

        private void CoursesCalendar_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            actualizar_calendario();
        }

        private void actualizar_calendario()
        {
            String date = dtpDesde.Value.ToString("yyyy/MM/dd");
            server = new Server.ServerClient();
            Server.calendarSession[] arrayS = server.querySessionsByDate(date);
            if (arrayS != null)
            {
                BindingList<Server.calendarSession> listaSesions = new BindingList<Server.calendarSession>(arrayS);
                this.calendario.actualizar_calendario(listaSesions);
            }
            else
            {
                this.calendario.limpiar_calendario();
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    String date = dtpDesde.Value.ToString("yyyy/MM/dd");
                    server = new Server.ServerClient();
                    Server.calendarSession[] arrayS = server.querySessionsByDate(date);
                    if (arrayS != null)
                    {
                        BindingList<Server.calendarSession> listaSesions = new BindingList<Server.calendarSession>(arrayS);
                        try
                        {
                            String fileName = fbd.SelectedPath+"/calendarioINFOSiS.csv";
                            // Check if file already exists. If yes, delete it.     
                            if (File.Exists(fileName))
                            {
                                File.Delete(fileName);
                            }

                            // Create a new file     
                            using (FileStream fs = File.Create(fileName))
                            {
                                // Add some text to file    
                                Byte[] title = new UTF8Encoding(true).GetBytes("Subject,Start date,Start time,End Date,End Time,Location\r\n");
                                fs.Write(title, 0, title.Length);
                                foreach(Server.calendarSession cs in listaSesions)
                                {
                                    Byte[] course = new UTF8Encoding(true).GetBytes(cs.courseName
                                        + "," + cs.inicio.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))
                                        + "," + cs.inicio.ToString("t", CultureInfo.CreateSpecificCulture("en-US"))
                                        + "," + cs.fin.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))
                                        + "," + cs.fin.ToString("t", CultureInfo.CreateSpecificCulture("en-US"))
                                        + "," + cs.aula+ "\r\n");
                                    fs.Write(course, 0, course.Length);
                                }
                                fs.Close();
                                MessageBox.Show("Se exportó el calendario en formato Google Calendar en el archivo calendarioINFOSiS.csv","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception Ex)
                        {
                            MessageBox.Show("Error al crear el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay cursos para exportar desde la fecha seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                
            }
        }
    }
}
