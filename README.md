# windows-forms-app-database-connection

This Windows Forms App(.NET Framework) project connects to a local SQL database on my computer and allows me to work with tables in a one-to-many relationship.
It uses two dataGridViews, one for each table. When selecting a row from the parent's dataGridView, the child's dataGridView only displays the rows with a matching foreign key. 
By selecting a parent entity, I can add a child with its ID and by selcting a child entity, I can update and delete it.
It uses App.config which makes the project work on any two tables in a 1:N relationship.
![prtsc_lab2](https://user-images.githubusercontent.com/62253444/115268409-e82b5700-a142-11eb-8950-e8fa80a0256c.png)
