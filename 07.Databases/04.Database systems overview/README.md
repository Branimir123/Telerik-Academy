###1.What database models do you know?
 - Relational
 - Network Model and Hierarchical
 - Object-Oriented
 - Object-Relational

###2.Which are the main functions performed by a Relational Database Management System (RDBMS)?

 - Creating / altering / deleting tables and relationships between them (database schema)
 - Adding, changing, deleting, searching and retrieving of data stored in the tables
 -  Support for the SQL language
 - Transaction management (optional)

###3.Define what is "table" in database terms.
- A table is a collection of related data held in a structured format within a database. It consists of columns, and rows.

###4.Explain the difference between a primary and a foreign key.
- Primary key uniquely identify a record in the table.	Foreign key is a field in the table that is primary key in another table.
- Primary Key can't accept null values.	Foreign key can accept multiple null value.
- By default, Primary key is clustered index and data in the database table is physically organized in the sequence of clustered index.	Foreign key do not automatically create an index, clustered or non-clustered. You can manually create an index on foreign key.
- We can have only one Primary key in a table.	We can have more than one foreign key in a table.

###5.Explain the different kinds of relationships between tables in relational databases.
- **One-to-Many Relationships**
A one-to-many relationship is the most common type of relationship. In this type of relationship, a row in table A can have many matching rows in table B, but a row in table B can have only one matching row in table A. For example, the publishers and titles tables have a one-to-many relationship: each publisher produces many titles, but each title comes from only one publisher.
Make a one-to-many relationship if only one of the related columns is a primary key or has a unique constraint.
The primary key side of a one-to-many relationship is denoted by a key symbol. The foreign key side of a relationship is denoted by an infinity symbol.
- **Many-to-Many Relationships**
In a many-to-many relationship, a row in table A can have many matching rows in table B, and vice versa. You create such a relationship by defining a third table, called a junction table, whose primary key consists of the foreign keys from both table A and table B. For example, the authors table and the titles table have a many-to-many relationship that is defined by a one-to-many relationship from each of these tables to the titleauthors table. The primary key of the titleauthors table is the combination of the au_id column (the authors table's primary key) and the title_id column (the titles table's primary key).
- **One-to-One Relationships**
In a one-to-one relationship, a row in table A can have no more than one matching row in table B, and vice versa. A one-to-one relationship is created if both of the related columns are primary keys or have unique constraints.
This type of relationship is not common because most information related in this way would be all in one table. You might use a one-to-one relationship to:
Divide a table with many columns.
Isolate part of a table for security reasons.
Store data that is short-lived and could be easily deleted by simply deleting the table.
Store information that applies only to a subset of the main table.
The primary key side of a one-to-one relationship is denoted by a key symbol. The foreign key side is also denoted by a key symbol.

###6.When is a certain database schema normalized?
 - Database normalization, or simply normalization, is the process of organizing the columns (attributes) and tables (relations) of a relational database to reduce data redundancy and improve data integrity.
 -  Normalization involves arranging attributes in tables based on dependencies between attributes, ensuring that the dependencies are properly enforced by database integrity constraints. Normalization is accomplished through applying some formal rules either by a process of synthesis or decomposition. Synthesis creates a normalized database design based on a known set of dependencies. Decomposition takes an existing (insufficiently normalized) database design and improves it based on the known set of dependencies.
###7.What are the advantages of normalized databases?
 - Read above

###8.What are database integrity constraints and when are they used?
- Enforce data rules which cannot be violated **Primary key** constraint
- Ensures that the primary key of a table has unique value for each table row **Unique key** constraint
- Ensures that all values in a certain column (or a group of columns) are unique **Foreign key** constraint
- Ensures that the value in given column is a key from another table **Check** constraint
- Ensures that values in a certain column meet some predefined condition

###9.Point out the pros and cons of using indexes in a database.
- Faster search
- Slower addition and removal of data
###10.What's the main purpose of the SQL language?
- Deal with relational databases
###11.What are transactions used for?
- Transactions are a sequence of database operations which are executed as a single unit.
###12.Give an example.
- A bank transfer from one account to another
###13.What is a NoSQL database?
- Use document-based model (non-relational)
- Schema-free document storage
- Support CRUD operations, indexing, querying, concurrency and transactions
- Highly optimized for append / retrieve
- Great performance and scalability
###14.Explain the classical non-relational data models.
- Document model (e.g. MongoDB, CouchDB): Set of documents, e.g. JSON strings
- Key-value model (e.g. Redis) Set of key-value pairs
- Hierarchical key-value Hierarchy of key-value pairs
- Wide-column model (e.g. Cassandra) Key-value model with schema
- Object model (e.g. Cache) Set of OOP-style objects
###15.Give few examples of NoSQL databases and their pros and cons.
- Flexible Data Model. Unlike relational databases, NoSQL databases easily store and combine any type of data, both structured and unstructured. You can also dynamically update the schema to evolve with changing requirements and without any interruption or downtime to your application.
- Elastic Scalability. NoSQL databases scale out on low cost, commodity hardware, allowing for almost unlimited growth.
- High Performance. NoSQL databases are built for great performance, measured in terms of both throughput and latency.
