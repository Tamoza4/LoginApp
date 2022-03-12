# LoginApp
Login and register new user interface connected to online SQL database

create SQL database and put this code in site database to create table:

```
CREATE TABLE Logindb (
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    UserName VARCHAR(50) NOT NULL UNIQUE,
    Name varchar(50) NOT NULL,
    Email varchar(50) NOT NULL,
    password VARCHAR(255) NOT NULL,
    created_at DATETIME DEFAULT CURRENT_TIMESTAMP
);

SELECT * from Logindb
```
after that put your database details in Login and register forms -- replace "****" to your details

```
Data Source=YourDomine.com or ip for database
Initial Catalog=Database Name
User Id=Database User ID
password=Paswword for Database User ID
```


Login Form:

![loginapp1](https://user-images.githubusercontent.com/101449907/158010536-af0d7295-e568-4bc9-9695-24fd59d6c3c7.png)

Connecting:

![loginapp2](https://user-images.githubusercontent.com/101449907/158010556-473da0d0-4879-48ca-9472-76547d26bcc2.png)

Welcome Form:

![loginapp3](https://user-images.githubusercontent.com/101449907/158010566-d0e6f23d-d12d-4e70-816e-ea3199366d75.png)

Register Form:

![loginapp4](https://user-images.githubusercontent.com/101449907/158010577-ebaef9d9-19f4-4d38-a203-86f9d4242e19.png)





