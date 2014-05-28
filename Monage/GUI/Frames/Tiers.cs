﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;

namespace Monage.GUI.Frames {
    public partial class Tiers : DockedFrame {
        Budget budget;
        public Tiers(Budget b) {
            InitializeComponent();
            budget = b;
        }
        public override string TitleAppend() { return (budget.ID == 0 ? "New" : "Edit") + " Budget"; }
        public override bool Ready(string con, string conf) { return Program.ConfirmReady(con, conf); }
    }
}