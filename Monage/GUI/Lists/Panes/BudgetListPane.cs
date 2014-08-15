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
using System.ComponentModel.DataAnnotations;
using Monage.GUI.Controls;

namespace Monage.GUI.Lists {
    public partial class BudgetListPane : Frame {
        private Budget Budget { get; set; }
        private SummaryFrame Frame { get; set; }
        private List<StepList> StepLists { get; set; }
        public BudgetListPane(Budget budget, SummaryFrame frame)
            : base(Position.TopCenter | Position.FullHeight, State.Confirm) {
            InitializeComponent();
            this.Budget = budget;
            this.Frame = frame;
            this.getList();
        }

        public void getList() {
            int y = 3;
            pnlTiers.Controls.Clear();
            this.StepLists = new List<StepList>();
            foreach (Tier tier in this.Budget.Tiers.OrderBy(x => x.Order)) {
                StepList sl = new StepList(this, tier);
                sl.Location = new Point(3, y);
                pnlTiers.Controls.Add(sl);
                this.StepLists.Add(sl);
                y += sl.Margin.Top + sl.Height + sl.Margin.Bottom;
            }
        }
        public void fixHeight() {
            int y = 3;
            foreach (StepList sl in this.StepLists) {
                sl.Location = new Point(3, y);
                y += sl.Margin.Top + sl.Height + sl.Margin.Bottom;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            this.Budget.AddTier();
            this.getList();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                this.Budget.Save();
                MessageBox.Show(Program.Window, "Budget Saved");
            } catch (ValidationException ex) {
                MessageBox.Show(Program.Window, ex.Message);
            }
        }
    }
}
