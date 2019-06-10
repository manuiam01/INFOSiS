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
    public partial class ProfileChangePassword : UserControl
    {
        private static ProfileChangePassword _instance;
        private static Panel _panelMdi;

        public static ProfileChangePassword Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ProfileChangePassword();
                return _instance;
            }
        }

        public static Panel PanelMdi
        {
            get => _panelMdi;
            set => _panelMdi = value;
        }
        public ProfileChangePassword()
        {
            InitializeComponent();
        }
    }
}
