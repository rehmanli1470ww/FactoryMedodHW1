

interface Button
{
    public void render();
    public void onClick();

}

class Windows : Button
{
    public void onClick()
    {
        throw new NotImplementedException();
    }

    public void render()
    {
        throw new NotImplementedException();
    }
}

class HTML : Button
{
    public void onClick()
    {
        throw new NotImplementedException();
    }

    public void render()
    {
        throw new NotImplementedException();
    }
}


abstract class Dialog
{
    public void render() { }
    public abstract Button createButton();  

}

class WindowsDialog : Dialog
{
    public override Button createButton()
    {
        throw new NotImplementedException();
    }
    
}

class WebDialog : Dialog
{
    public override Button createButton()
    {
        throw new NotImplementedException();
    }
}



