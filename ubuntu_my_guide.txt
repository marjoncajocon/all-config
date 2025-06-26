---- for remote ssh
sudo apt update
sudo apt install openssh-server
sudo systemctl enable ssh
sudo systemctl start ssh


sudo ufw allow ssh
# turn on the firewall
sudo ufw enable


--- view all active port
ss -tuln
--- enabled if block the port
sudo ufw allow 5000/tcp

---- denied
sudo ufw deny 5000/tcp

ssh username@server_ip



---- start for desktop icon
[Desktop Entry]
        Name=Application Name
        Comment=Brief description of the application
        Exec=/path/to/your/executable
        Icon=/path/to/your/icon.png
        Type=Application
        
        
        
        
        
        then filename must be myapp.desktop
        
        
        
        
        
        
       # Add 
       sudo chown -R marjon:marjon /usr/local/mysql/data
       
       
       /path/to/mariadb/bin/mysqld --initialize --user=mysql --datadir=/usr/local/mysql/data
       
       
       
# create Service in Linux

#------------ start file

[Unit]
Description=My Go Application
After=network.target

[Service]
Type=simple
ExecStart=/home/user/myapp
Restart=on-failure
User=john
WorkingDirectory=/home/user/

[Install]
WantedBy=multi-user.target


#---------- End File


example: 
[Unit]
Description=Custom MariaDB Service
After=network.target

[Service]
User=mysql
Group=mysql
ExecStart=/usr/local/mysql/bin/mysqld --datadir=/usr/local/mysql/data
Restart=on-failure
PIDFile=/usr/local/mysql/data/mysqld.pid
LimitNOFILE=1024

[Install]
WantedBy=multi-user.target

sudo nano /etc/systemd/system/myapp.service

-- reload service to know the new service
sudo systemctl daemon-reload

-- enable and start the service
sudo systemctl daemon-reload
sudo systemctl enable myservice.service
sudo systemctl start myservice.service


--- to stop service
sudo systemctl stop myapp.service
sudo systemctl disable myapp.service

#info
You should edit the following parts in the systemd service file:

    ExecStart  
        Replace /path/to/your/myapp with the full path to your compiled binary.
        Example: /home/user/myapp

    User  
        Replace your_username with the Linux username that should run the service.
        Example: john

    WorkingDirectory (optional)  
        Set this to the directory where your app runs or needs to operate from.
        Example: /home/user/
        
        
        
        
        
        
        
        
        
  -------------- add windows shared to linux
  
  Install CIFS utilities:

CopyRun
sudo apt update
sudo apt install cifs-utils
Create a mount point:

CopyRun
sudo mkdir /mnt/shared
Mount the shared folder:

CopyRun
sudo mount -t cifs -o username=your_username //windows_machine_ip/shared_folder /mnt/shared




-------------------------- full repair command

sudo rm /var/lib/dpkg/lock-frontend
sudo rm /var/lib/dpkg/lock
sudo rm /var/cache/apt/archives/lock
sudo dpkg --configure -a


sudo apt update
sudo apt --fix-broken install
sudo dpkg --configure -a
sudo apt upgrade -y
sudo apt autoremove -y
sudo apt clean



---------------------- to play youtube live and facebookk or any live to suppport codecs --------------------------------

-> sudo apt-get install ubuntu-restricted-extras
// if gui is display to click okay click the tab to select ok

--------------------- configuration of the graphical user interface in ubuntu or linux --------------------------
-> nano /etc/default/grub
