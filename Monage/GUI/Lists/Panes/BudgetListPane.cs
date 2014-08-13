using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.Models;
using Monage.GUI.Frames;

namespace Monage.GUI.Lists {
    public partial class BudgetListPane : Frame {
        private Budget Budget { get; set; }
        private SummaryFrame Frame { get; set; }
        public BudgetListPane(Budget budget, SummaryFrame frame) {
            InitializeComponent();
            this.Budget = budget;
            this.Frame = frame;
        }
    }
}
