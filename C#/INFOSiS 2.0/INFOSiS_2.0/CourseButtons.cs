﻿using System;
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
    public partial class CourseButtons : UserControl
    {

        private static CourseButtons _instance;
        private static Panel _panelMdi;

        public static CourseButtons Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CourseButtons();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public CourseButtons()
        {
            InitializeComponent();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }

            if (!PanelMdi.Controls.Contains(CoursesCalendar.Instance))
            {
                PanelMdi.Controls.Add(CoursesCalendar.Instance);
                CoursesCalendar.Instance.Dock = DockStyle.Fill;
                CoursesCalendar.PanelMdi = PanelMdi;
                CoursesCalendar.Instance.Visible = true;
                CoursesCalendar.Instance.BringToFront();
            }
            else
            {
                CoursesCalendar.Instance.Visible = true;
                CoursesCalendar.Instance.BringToFront();
            }
        }

        private void btnCourseRegister_Click(object sender, EventArgs e)
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }

            if (!PanelMdi.Controls.Contains(CourseRegister.Instance))
            {
                PanelMdi.Controls.Add(CourseRegister.Instance);
                CourseRegister.Instance.Dock = DockStyle.Fill;
                CourseRegister.PanelMdi = PanelMdi;
                CourseRegister.Instance.Visible = true;
                CourseRegister.Instance.BringToFront();
            }
            else
            {
                CourseRegister.Instance.Visible = true;
                CourseRegister.Instance.BringToFront();
            }
        }

        private void btnCourseModify_Click(object sender, EventArgs e)
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }

            if (!PanelMdi.Controls.Contains(CourseModify.Instance))
            {
                PanelMdi.Controls.Add(CourseModify.Instance);
                CourseModify.Instance.Dock = DockStyle.Fill;
                CourseModify.PanelMdi = PanelMdi;
                CourseModify.Instance.Visible = true;
                CourseModify.Instance.BringToFront();
            }
            else
            {
                CourseModify.Instance.Visible = true;
                CourseModify.Instance.BringToFront();
            }
        }

        private void btnCourseReport_Click(object sender, EventArgs e)
        {
            foreach (Control item in PanelMdi.Controls.OfType<Control>())
            {
                PanelMdi.Controls.Remove(item);
            }

            if (!PanelMdi.Controls.Contains(CourseReport.Instance))
            {
                PanelMdi.Controls.Add(CourseReport.Instance);
                CourseReport.Instance.Dock = DockStyle.Fill;
                CourseReport.PanelMdi = PanelMdi;
                CourseReport.Instance.Visible = true;
                CourseReport.Instance.BringToFront();
            }
            else
            {
                CourseReport.Instance.Visible = true;
                CourseReport.Instance.BringToFront();
            }
        }
    }
}
