using ChainOfResponsibility.Components;
using ChainOfResponsibility.Containers;

var panel = new Panel(modalHelpText: "Modal Help Text");

var dialog = new Dialog(panel, "Dialog Wiki URL")
{
    BubbleUp = false
};

panel.Children = dialog;

var button = new Button(dialog)
{
    Tooltip = "Button Tooltip",
};

dialog.Children = button;

button.ShowHelp();