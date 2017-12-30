# Deadlock / Livelock
## Deadlock
A program uses resources in the following ways:
* Requests a resource
* Uses a resource
* Releases a resource

Deadlock is a problem where a set of processes are blocked because each process holding a resource
and waiting for another resource aquired by some other process.  See the [Dining Philosopher Problem](https://en.wikipedia.org/wiki/Dining_philosophers_problem)

### Causes
Deadlock arises when the following four coditions hold simultaniousely:
* Mutual Exclusion: One or more resources are non shareable
* Hold and wait: process holds at least one resource while waiting for others
* No Preemption: a resource cannot be taken from a process unless the process releases
* Circular Wait: set of processes are waiting on each other in circular form

### Solutions
Three ways to handle deadlock:
* Deadlock prevention and avoidance: don't let the system get into that state.
* Deadlock detection and recovery: let deadlock occur, then do preemption to handle it.
* Ignore the problem and hope it goes away: let them happen, and reboot when they do.
  * This is the approach both Windows and Linux take.

### Deadlock Prevention
We can prevent deadlock by preventing any of the four causes described above, specifically:
* Eliminate Mutual Excluion: Greate solution where possible.
* Eliminate hold and wait: allocate all the required resources at the program start. That way
  hold and wait pattern is eliminated.  
  * The dowside is that all the resources are held even when they are not needed, leading to 
    resource starvation.
* Preemt resources: take resources held by a lower priority process and assing them to a higher 
  priority process.
* Elimanate circular wait: each resource will be assigned a number and a process can only request 
  resources in increasing number.  Again see dining philosophers for Dijkstras solution.

### Deadlock Detection
If resources have a single instance, we can run an algorithm for cycle dection in the resource
allocaiton graph. Presence of a cycle would point to a deadlock. When there are multiple instances
of a resource a mere presence of a cycle does not guarantee deadlock.

### Deadlock Recovery
To recover from deadlock we have two otions:
* Kill the processes involved in deadlock one by one
  * check if deadlock is still present.
* Resource Preemption
  * Resources are pre-empted from a process involved in a deadlock and allocated to other processes
  * This leads to a system recovering from a deadlock.

## Livelock
Livelock is similar to deadlock, but the two or more processes change their state in response to
other processes, but do not do any useful work. It is a spcial case of resource starvation.

Think two people meet in a corridor, try to get out of each others way and end up doing nothing but 
swaying from side to side. You can enter into this state when you attempt to recover from deadlock.

## Links
* https://www.geeksforgeeks.org/operating-systems/ - G4g
* https://stackoverflow.com/questions/6155951/whats-the-difference-between-deadlock-and-livelock - S0