using System;

class Car
{
    private string registrationNo;
    public string RegistrationNo 
    {
        get {return registrationNo;}
        set {registrationNo = value;}
    }
    public string Model {get; set;}
    public int Year {get; set;}

    public void stop()
    {
        Console.WriteLine("Stop car");
    }

    public bool moveFoward()
    {
        return true;
    }

    public bool moveBackward()
    {
        return true;
    }
}