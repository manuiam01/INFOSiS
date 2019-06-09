using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFOSiS_2._0
{
    public partial class ProfessorRegister : UserControl
    {
        private static ProfessorRegister _instance;
        private static Panel _panelnotThisProfessorRegister;

        public static ProfessorRegister Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfessorRegister();
                return _instance;
            }
        }

        public static Panel PanelnotThisProfessorRegister
        {
            get => _panelnotThisProfessorRegister;
            set => _panelnotThisProfessorRegister = value;
        }

        public ProfessorRegister()
        {
            InitializeComponent();
           ///////estas presionando algo xdno
           ///monga, estabas llamando loscomponentes fuera de los métodosajjaj.a.ja.
           /// sisi ya me di cuenta tmrya gracias xd
           /// igual esta mal o q haces por qué has creado un panel dentro del user control?s
        }
        
        
    }
}
