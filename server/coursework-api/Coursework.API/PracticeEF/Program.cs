using Coursework;
using Microsoft.EntityFrameworkCore;

// We will try to start working with the entity framework
// 1. Create the models for entities

// 2. Create the DB Context using the OnConfiguring method for 
// connection string details

// 3. Establish a connection with SQL Server with the dbcontext to test out
// the onconfiguring method

using var practiceContext = new PracticeContext();

Console.WriteLine("Made a connection to SQL Server");

var pmodel2 = new PracticeModel2()
{
    Description = "Testing2"
};

// 4. Add a new row to the table and verify

Console.WriteLine("Adding the new object to the DB");

//practiceContext.practice2.Add(pmodel2);
//practiceContext.SaveChanges();

Console.WriteLine("Supposedly add the new object");

var allRows2 = practiceContext.practice2.ToList();

Console.WriteLine("Printing all objects in the new Practice 2 Table");
foreach (var pracmod2 in allRows2)
{
    Console.WriteLine($"id: {pracmod2.Id} and the description is {pracmod2.Description}");
}

// 5. Deleting a row requires querying the row, finding it and passing it to the delete method
var practice2set = practiceContext.practice2;
var row2 = practice2set.FirstOrDefault(row => row.Id == 2); // is null by default
//practice2set.Remove(row2);
//practiceContext.SaveChanges();

foreach (var pracmod2 in allRows2)
{
    Console.WriteLine($"id: {pracmod2.Id} and the description is {pracmod2.Description}");
}

// What will first or default return if we cant find the row in question
var rowx = practice2set.FirstOrDefault(row => row.Id == 344); // is null by default

// 6. Updating a row 
// You pick up the object and make the update to that object
// since the EF API keeps track of entities retrieved using the context then when you
// "saveChanges" that implies an update statement since the updated entity will be marked as "Modified"
try
{
    var updateEntity = practice2set.FirstOrDefault(x => x.Id == 1);
    updateEntity.Description = "Updated dddddd1";
    practiceContext.SaveChanges();
} catch (DbUpdateException e)
{
    Console.WriteLine($"The exception {e}");
}

