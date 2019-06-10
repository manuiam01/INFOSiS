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
    public partial class ProfileButtons : UserControl
    {
        private static ProfileButtons _instance;
        private static Panel _panelMdi;

        public static ProfileButtons Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileButtons();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public ProfileButtons()
        {
            InitializeComponent();
        }
    }
}
