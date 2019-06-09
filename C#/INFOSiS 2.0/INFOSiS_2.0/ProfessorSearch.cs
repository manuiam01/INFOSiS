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
    public partial class ProfessorSearch : UserControl
    {

        private static ProfessorSearch _instance;
        private static Panel _panelMdi;

        public static ProfessorSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfessorSearch();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }

        public ProfessorSearch()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ProfessorRegister.Instance.BringToFront();
        }


    }
}
