# create account:
  CREATE USER 'admin'@'192.%' IDENTIFIED BY 'mypassword';
  GRANT ALL PRIVILEGES ON `MyDatabase`.* TO 'admin'@'192.%';
  GRANT ALL PRIVILEGES ON `MyDatabase`.* TO 'admin'@'192.%';
  FLUSH PRIVILEGES;
  EXIT;

# account for all IP:
  CREATE USER 'username'@'%' IDENTIFIED BY 'password';



# grant all database
GRANT ALL PRIVILEGES ON *.* TO 'username'@'192.%';






# REMOVING USER:
  DROP USER 'username'@'192.%';
  FLUSH PRIVILEGES;
  EXIT;



# REMOVING PRIVILEGES:
  REVOKE <privilege> ON <database>.* FROM 'username'@'host';


  * sample:
    REVOKE SELECT, INSERT ON yourdatabase.* FROM 'username'@'192.%';

    # all privilege remove
    #REVOKE ALL PRIVILEGES ON yourdatabase.* FROM 'username'@'192.%';
    # all thedabase
    REVOKE ALL PRIVILEGES ON *.* FROM 'username'@'192.%';
    FLUSH PRIVILEGES;
    EXIT;
