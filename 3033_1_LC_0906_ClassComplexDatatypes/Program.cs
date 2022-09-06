// Thuan (Trae) Tran ID: 113437456
// Class complex datatypes

using System.Security.Cryptography;

int i; // room card and room number
string str;// room card

str = new String("Trae Tran This is a str"); // 102 is room number

str = "another str"; // 103 creates another room number in the memory
i = 20;// you copy the values inside that room

HotelRoom hm;
hm = new HotelRoom(); // HotelRoom() is the constructor function  room number = 110
hm.numBeds = 2; // syntax to access numBeds (member fields)

hm = new HotelRoom(2, false); // room number = 112 
HotelRoom hm2;
hm2 = hm; // copies 112


HotelRoom hm1 =  new HotelRoom(3, true);

//HotelRoom.restaurant = "Sloopy Joe's";  // required syntax to reference static field

//Console.WriteLine(); required syntax to reference static function

hm.numBeds = 2;


// Complex datatype
// string
string str2 = new string("str1");
str2 = "str2 this is MIS 3033";

//str2.Contains(str); // member function applied BC variable
//string.Format(str); // static function applied BC datatype


// experiment with
// str2.ToLower(),
// str2.ToUpper(),
// str2.Split() splits whatever is in the parameter

DateTime date1;
date1 = new DateTime();

date1 = DateTime.Now;

DateTime date2 = new DateTime(2000, 2, 20, 8, 30, 0);

TimeSpan ts1 = date1 - date2; // timespan will calculate the difference for you

//date1.ToString() help correctly formats time for read friendly

// Console.WriteLine(ts1.ToString("MMM""DD""YYYY"));    


Console.ReadLine(); //End of code before exiting

public class HotelRoom // complex datatype
{

    // overload vs override
    // overload involves many same function names with different parameters

    public HotelRoom() // constructor function by default, does not NEED a return
    {

    }


    //this. syntax references member field's variable
    public HotelRoom(int numBeds, bool canSmoke) // member function with int numBeds and bool canSmoke (2 parameters)
    {
        this.numBeds = numBeds;
        this.canSmoke = canSmoke;
    }


    // datatype1 function_name()
    // {
    // ...
    // return var;
    // }

    public int numBeds; // member fields
    public bool canSmoke;
    public string coffeeMachine;
    public static string restaurant; // static fields (one to many)


}