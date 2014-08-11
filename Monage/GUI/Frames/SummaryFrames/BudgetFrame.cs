using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Monage.GUI.Lists;
using Monage.Models;

namespace Monage.GUI.Frames {
    public partial class BudgetFrame : SummaryFrame {
        public BudgetFrame() {
            InitializeComponent();
            this.ContentPane = pnlEditor;
            budgetsFrame.Set(this);
        }
        public override string Title() { return "Financial Summary"; }

        public override void Ready() {

        }
    }
}
