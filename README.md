<h1 align="center" id="title">BD Intern Task</h1>
<h3 align="center" id="title">by Jonathan S</h3>

<p id="description">An MVC (.NET 7) application which is able to Create a customer and View all customers with associated Order count sorted by newest customer first.</p>

<h2>Database Diagram:</h2>

<img src="https://i.ibb.co/VCWnYSG/sql-database-diagram.png" alt="db-diagram" width="1080px" height="400/">

  
  
<h2>Features</h2>

Here are the project's features:

*   Add Customer
*   View Order Count for each customer
*   Customers sorted by newest first
*   Confirmation message upon adding a customer

<h2>🛠️ How To Use:</h2>

<p>1. Download the repo</p>

<p>2. Open the .sln file</p>

<p>3. Run the project in Visual Studio</p>

<p>4. Click "All Customers" in the navbar to view 2 sample customers</p>

<p>5. Click "Create Customer" in the navbar to add a new customer</p>  

<p>6. Return to "All Customers" to view updated list of customers</p>  

<h2> Notes </h2>

<p>I began by designing tables and database relationships locally in SQL Server Management Studio. The tables were then scaffolded to "Models/DB" using the scaffold dbcontext command</p>

<p>There is a GET method to fetch the Create customer page, a GET method to get the list of customers, and a POST method to create a new customer</p>

<p>Customers and Orders are stocked in memory using Lists</p>

<p>I have used a ViewModel to combine customers and ordercount</p>

<h2>Future Steps</h2>

<p>I would like to recreate this app using my local db. I did not do it this way in order to provide the team with a working application</p>

<p>I would ideally use Micrsoft Identity for customers and utilise Role authorisation and password hashing features</p>
<p>After that I would move on to making a shop display for products complete with CRUD operations</p>
<p>Finally I would work on Cart/Payment/Order components</p>
<p>There is still a lot I'd like to do on this app such as  validation, regex and figure out how to use dependency injection to remove the orders List from CustomerController in order to seperate concerns.</p>

  
<h2>💻 Built with</h2>

Technologies used in the project:

*   .NET 7 MVC
*   EFCore
* SQL
