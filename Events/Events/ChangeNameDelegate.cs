namespace Events
{
    //public delegate void ChangeNameDelegate(string existsName, string newName);
    public delegate void ChangeNameDelegate(object sender, ChangeNameEventArgs args);
}
