using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjekt
{
    class EmailVM
    {
        [DXCategory("Property Changed")]
        public event FocusedRowChangedEventHandler FocusedRowChanged;

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            GridView view = sender as GridView;
            if (view == null) return;
            if (view.IsGroupRow(e.FocusedRowHandle))
            {
                bool expanded = view.GetRowExpanded(e.FocusedRowHandle);
                view.SetRowExpanded(e.FocusedRowHandle, !expanded);
            } 
        }

    }
}
