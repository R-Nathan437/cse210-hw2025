using System.ComponentModel.DataAnnotations;

public class Scripture
    {
    private string _scripture;
    private Reference _reference;

    public Scripture(string verse, Reference reference)
    {
        _scripture = verse;
        _reference = reference;

    }    
    
    public string convertToString()
    {
        return string.Format("{0}", _scripture);
    }

}