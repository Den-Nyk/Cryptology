using System.Collections;
using System.Windows.Forms;

public class ListViewColumnSorter : IComparer
{
    private CaseInsensitiveComparer ObjectCompare;
    public int SortColumn { get; set; }
    public SortOrder Order { get; set; }

    public ListViewColumnSorter()
    {
        SortColumn = 0;
        Order = SortOrder.None;
        ObjectCompare = new CaseInsensitiveComparer();
    }

    public int Compare(object x, object y)
    {
        int compareResult;
        ListViewItem listviewX, listviewY;

        listviewX = (ListViewItem)x;
        listviewY = (ListViewItem)y;

        compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);

        // Calculate correct return value based on object comparison
        if (Order == SortOrder.Ascending)
        {
            return compareResult;
        }
        else if (Order == SortOrder.Descending)
        {
            return (-compareResult);
        }
        else
        {
            return 0;
        }
    }
}