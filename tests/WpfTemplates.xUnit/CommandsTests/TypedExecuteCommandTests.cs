using WpfTemplates.Shared.Mocks;
using WpfTemplates.Shared.Models;

namespace WpfTemplates.xUnit.CommandsTests;

public class TypedExecuteCommandTests
{
    [Fact]
    public void TypedCommand_Success()
    {
        var sut = new CommandTestMock();

        var title = "Title 1";
        var text = "Title 1";

        Item item = new(title, text);

        sut.TypedCommandTest.Execute(item);

        Assert.Equal(title, sut.CurrentItem!.Title);
        Assert.Equal(text, sut.CurrentItem!.Text);
    }

}
