# WinForm
 Simplest possible C# Winform app  
- Downloaded [.gitignore](https://github.com/github/gitignore/blob/main/VisualStudio.gitignore) *before* GitHub Desktop commit of Visual Studio configuration  
![](WinForm.png)  
![](Configure.png)  
- Form size can be changed by dragging tiny control boxes with mouse pointer  
  or by `Size` under **Layout** in `Properties` box (lower right)  
	- Form title can be edited in `Text` under **Appearance** in `Properties` box
- [`View > Toolbox` (pin)](https://learn.microsoft.com/en-us/visualstudio/ide/reference/toolbox?view=vs-2022) -
    [*descriptions*](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/controls-to-use-on-windows-forms)
    - Toolbox [Controls](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/controls-to-use-on-windows-forms)
 	can be dragged and dropped onto the form;  
	  corresponding `Properties` appear.
	- **Avoid double-clicking Controls**; Designer will assume that events are wanted...   
	- Change `TextBox` **Behavior** `ReadOnly` property to **True** for using it as a *display* window:  
	```
  		string foo = "watch this";
  		textBox1.Text = foo;
	```
![](VSform.jpg)  
