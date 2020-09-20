# OrderManagement
Order Management is a sample WPF application built using .Net framework 4.7.2. This application is designed using MVVM pattern. It also has a unit test project which uses xUnit test framework.

## Setup 
Follow these steps to get your development enviornment set up:
1. Clone the repository
2. Build the project (It should automatically restore the nuget projects, it uses Uniconta common and Uniconta Windows api for data access)

## Technologies 
* .Net Framework 4.7.2
* WPF
* Xunit
* Uniconta

# Task Requirements
This application comes with basic datacess methods, models.

Complete the application by creating two Main pages
1. eShop Sales order Grid page (where it should show sales order header data) and with following features 
* Edit(clicking on edit should lead to edit page where user can inspect the data and perform actions like accept or decline the eorder)
* Lines (clicking on lines should lead to lines page that shows all the lines that belongs to the selected eshop sales header)
* TransferAccpeted( clicking on this feature will selects all the accepted eshop sales headers and its lines and transfers them to SalesOrderclients tables (SalesOrderClientModel and SalesOrderLineclientModel)

2. SalesOrders Pages, this pages is just a flat grid page that shows content of the sales order headers which are transferred by the eshop sales order page. It should also contains a Lines button that exposes the sales order lines of a selected header.
