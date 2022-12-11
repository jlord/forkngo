public class Person 
{
	public string FirstName {get; set;}
	public string LastName {get; set;}
	public double Age {get; set;}
	public string Address {get; set;}	

	public Person(
		string firstname,
		string lastname,
		double age,
		string address)
	{
		this.FirstName = firstname;
		this.LastName = lastname;
		this.Age = Age;
		this.Address = address;
	}
}
