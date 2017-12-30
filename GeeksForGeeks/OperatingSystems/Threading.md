# Processes / Threads / Concurrency
## General
* Process - process is an instance of a computer program that is being executed. It can be made up
of various threads that can be executed concurrently.
* Thread - thread is a path of execution within a process.
* Concurrency - running multiple processes at the same time.[Dining philosophers problem](https://en.wikipedia.org/wiki/Dining_philosophers_problem).

### Thread
Threading is used to break up a process such that it can be ran more efficiently without being
blocked.  For example, MS word uses one thread to format text, the other to listen to user input.
Such that even if one of the threads is locked up with work, the other one is still listening and
will catch up once the other thread is freed up.

Difference between a process and a thread is that threads of the same process run in the same 
memory space, whereas different processes run in different memory threads.

Threads share with each other code section, data section and OS resources like open files and 
signals. A thread does have its own program counter, register set and stack space.

Advantages of threads of processes:
* Responsiveness - if a process is divided into multiple threads, if one completes it can be
  responded to by the program.
* Faster context switch - switching between threads is faster than switching between processes, which
  ads overhead to the CPU.
* Effective utilization of multiprocessor system - each thread can run on its own CPU.
  * This can also be amplified on multithreaded CPUs.
* Resource sharing - code and data can be shared by all threads.
* Communication - communication between threads is easier because they share common memory address
  space.

Types of Threads:
* User level thread - programs we run.
* Kernel level thread - OS level threading, more hardware dependant, more complex.

### MultiThreading Models
There are three threading models:
* Many to many
  * Multiple user level threads correspond with same or lesser number of kernel level threads.
  * The advantage is that if a user thread is blocked, we can schedule other user threads to another
    kernel thread
* Many to one
  * Multiple user threads are mapped to a single kernel thread. When a thread makes a blocking call
    the entire system blocks.
* One to one
  * One user thread, one kernel thread. Problem here is that creating a new user thread reqires an 
    avalable corresponding kernel thread.



### Spooling
SPOOL is *S*imultanious *P*erepheral *O*perations *O*n*L*ine. It is a buffering mechanism in which
data is temporarily held to be used and executed by a device, program or a system. Data is stored
in memory until a program requests it for execution.

Computer perepherals like printers are very slow compared to the rest of the sytem, so a need for 
a spool is present. Spooling will collect data for execution later on. SPOOL is usually processed in
a FIFO manner.



### Zombie Process
When a process is created using fork() command the address spce of the parent is replicated. If the
parent calls wait() then the execution of parent is suspended until the child process exits. At the
termination of the child, 'SIGCHILD' command is signaled. Once the parent receives that signal it
removes the child from the process table. However if the parent does not do this, the child can 
remain in the proces table. This is known as a zombie process.

## Links
https://www.geeksforgeeks.org/operating-systems/ - OS g4g