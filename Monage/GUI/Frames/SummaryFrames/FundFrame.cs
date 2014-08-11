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
    public partial class FundFrame : SummaryFrame {
        public FundFrame() {
            InitializeComponent();
            this.ContentPane = pnlEditor;
        }
        public override string Title() { return "Financial Summary"; }

        public override void Ready() {
            revenueFrame.Set(this);
            expenseFrame.Set(this);
        }
    }
}
