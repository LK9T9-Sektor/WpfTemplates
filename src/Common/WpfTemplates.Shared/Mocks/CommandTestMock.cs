using WpfTemplates.Shared.Commands;
using WpfTemplates.Shared.Models;

namespace WpfTemplates.Shared.Mocks;

public class CommandTestMock
{
    public CommandTestMock()
    {
        TypedCommandTest = new TypedCommand<Item>(TypedCommandTestExecute);
    }

    public ITypedCommand<Item> TypedCommandTest { get; }

    public Item? CurrentItem { get; private set; }

    private void TypedCommandTestExecute(Item? item)
    {
        if (item == null) { return; }

        CurrentItem = item;
    }

}
