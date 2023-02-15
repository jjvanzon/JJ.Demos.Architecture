namespace JJ.Demos.Architecture.Presentation.Presenters;

public class TreePresenter
{
    public void ExpandNode(TreeViewModel viewModel, int id)
    {
        NodeViewModel node = viewModel.Nodes.Single(x => x.ID == id);
        node.IsExpanded = true;
    }
}