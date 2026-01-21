struct Team { 
    public string id {get; set; }
    public string name {get; set; }
    int _win {get; set; }
    int _draw {get; set; }
    int _loss {get; set; }
    public int Points
    {
        get { return (_win * 3) + _draw; }
    }
    public int loss 
    { 
        get { return _loss; } 
        set 
        { 
            _loss = value; 
        }
    }
    public int draw 
    { 
        get { return _draw; } 
        set 
        { 
            _draw = value; 
        }
    }
    public int win 
    { 
        get { return _win; } 
        set 
        { 
            _win = value; 
        }
    }
    public Team() {
        id = string.Empty;
        name = string.Empty;
        _win = 0;
        draw = 0;
        _loss = 0;
    }
    public void Play(){ }
    public void HirePlayer() { }
    public void Print() { }    
}
