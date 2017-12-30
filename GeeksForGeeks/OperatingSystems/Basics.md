# What happens when we turn on a computer
## General
```
System Startup     | BIOS
Stage 1 Bootloader | Master Boot Record
Stage 2 Bootloader | GRUB
Kernel             | Linux
Init               | User Space
```

BIOS Chip looks into a fixed place (lowest numbered hard disk) for a special program called a boot
loader. Boot loader is pulled into memory and started. Boot loader's job is to start the operating
system.

### BIOS
BIOS runs a POST (*P*ower *O*n *S*elf *T*est). It checks the BIOS and the CMOS RAM and then
checks all the hardware devices connected to a computer and if any errors are found they are 
displayed on screen a series of beeps are heard.

### Master Boot Record
MBR is a small program that starts when a computer is booting to find the operating system. It is 
usually found in the first sector, first head, first cyclinder of the hard drive.  Once the MBR 
is in memory it will run a boot loader that will find the OS and load it into memory, handing off
control to the OS.

### init
init is the last step of the kernel boot sequence. It looks in the file /etc/inittab to see if there
is an entry in the initdefault. This is used to determine the initial run level of the system. 

Here are the run levels:
* 0 => System Halt
* 1 => Single User Mode
* 3 => Full Multiuser Mode with Networking
* 5 => Full Multiuser Mode with Networkign and X Display Manager
* 6 => Reboot

The above design is SysV, but there are others like systemd upstart. Upstart is being used by 
Ubuntu since 2006.  Systemd is used by CentOS and consiquently Amazon Linux.

For upstart the configs are not in the etc/inittab, but in etc/init and etc/init.d.
For systemd the configs are not in the etc/inittab, but in /etc/sysconfig and /etc/default, but 
they are not recommended to be used or modified as described [here](http://0pointer.de/blog/projects/on-etc-sysinit.html).

### After
After this various daemons start up, the most important of which is the X server daemon, which is
in charge of the display, keyboard and mouse. When X server daemon is started you see the graphical
user interface, and a login screen is displayed.

## Links
* https://www.geeksforgeeks.org/what-happens-when-we-turn-on-computer/ - g4g



