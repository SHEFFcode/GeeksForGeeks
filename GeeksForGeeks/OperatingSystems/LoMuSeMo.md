# Locks / Mutexes / Semaphores / Monitors
## General
Resource synchronization is a problme that arises when there are cooperating processes. A critical
section is a secion that can only be accesses by a single process at a time, and its state needs
to be shared between different processes.

Any solution to the critical seciton problem must satisfy three requirements:
* Mutual exclusion: when one process is in the critical seciton, no other process is allowed in there.
* Progress: if no process is in the cirtical section, no other process must be allowed to block it 
  from entering.
* Bounded Waiting: a bound must be present of how many times other processes can be allowed to access
  the critical secitons after a process has made a request to enter it.

### Peterson Solution
In Petersons solution there are 2 shared variables:
* boolean flag: initally set to false
* int turn: process whose turn it is to enter a seciton

```
do {
  flag[i] = true;
  turn = j;
  while(flag[j] && turn == j) {
    //critical section
  }
  flag[i] = false;
  //remainder section
} while (true)
```
Disadvantages:
* Involves busy waiting
* Limited to 2 processes

### Test and Set
We have a shared lock that can have one of two values: 0 or 1.
Before entering into a critical section, the process inquires about the lock:
* If its locked it keeps waiting
* If its not locked, goes into critical section.

### Semaphores
A semaphore is an integer variable that can only be accessed through two operations: wait() and 
signal(). There are two types of semaphores:
* Binary Semaphores:
  * Can either be 0 or 1. They are also known as **mutex** locks.
  * All processses can share the same mutex semaphore initialized to 1.
    * They then wait until the lock becomes 0.
    * Then the process makes semaphore 1 again and enters the critical section
    * When it completes its critical section, it sets the value back to 0.
* Counting Semaphores:
  * They can have any value and are not restricted over a certain domain.
  * Can be used to monitor access to a resource that has a limitation on the number of simulanious
    accesses.
  * It can be initialized to the number of instances of the resource.
  * Whenever someone wants to access the resource, it checks the number of available resources,
    and if it is above 0, it uses the resource and decrements the semaphore.
  * After its done using the resource, it will increment the counter.

### Mutex
Mutex is a lock. It's only two possible states are locked and unlocked. It's purpose is to ensure 
atomic (only one) access to a resource.

### Monitor
Monitor is a way to achieve process synchronization. It is used to achieve mutual exclusion
between processes. wait() and notify() constructs.

```
Monitor {
  variables;
  conditional variables;
  procedure1();
  procedure2();
}
```

Processes running outside the monitor cant access internal variable of a monitor, but can call 
procedures on the monitor. 

Only one process at a time can execute code inside monitors.

In a wait operation, we queue up all the calls to the motnitor. In the signal operation we run
processes from the qeueue.

### Mutex vs Semaphore
Consider a problem where we have a consumer and producer. Say we have an ingestion endpoint that
takes in a large amount of data, and stores it to redis. We have another system which goes in and 
reads on interval from redis, combines entries and stores them to S3. Such system would need a way
to make sure that a signle resource is not being written to and read from at the same time, as that
can lead to data corruption.

**Using a mutex**

Mutex Provides mutual exlusion and either the ingestor or the reader will have access to a given
resource at any one time.

Only one thread can aquire a mutex, which means that only the owner can release the lock.

If a thread that already locked a mutex tried to lock it again, it would enter deadlock state.

The downside, that only a single process can work on the entire system.

**Using a semaphore**
A semaphore is a generalized mutex. We can split our redis into single keys, and a semaphore can be
associated with each of those keys. The ingestor and reader can work on different sections.

Mutex is more about locking, whereas semaphore is more about signaling.  A binary semaphore is 
similar to but is not identical to a mutex.

Mutex is more of a I am done, you can go ahead signal. It can have multiple values and many processes
can aquire access at the same time, but there is a limit on the total number of concurrent operations.

## Links
* https://www.geeksforgeeks.org/operating-systems/ - g4g
* https://www.youtube.com/watch?v=DvF3AsTglUU - HowTo



