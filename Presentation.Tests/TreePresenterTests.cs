namespace JJ.Demos.Architecture.Presentation.Tests;

public class TreePresenterTests
{
    [Fact]
    public void Test_TreePresenter_ExpandNode()
    {
        // Arrange
        var treePresenter = new TreePresenter();
        
        var treeViewModel = new TreeViewModel
        {
            Nodes = new List<NodeViewModel>
            {
                new() { ID = 1 },
                new() { ID = 2 }
            }
        };

        // Assert
        Assert.False(treeViewModel.Nodes[1].IsExpanded);

        // Act
        treePresenter.ExpandNode(treeViewModel, 2);

        // Assert
        Assert.True(treeViewModel.Nodes[1].IsExpanded);
    }
}
