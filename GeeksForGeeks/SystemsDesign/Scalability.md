# Scalability

## General
There are two methods of addressing system load growth: 
* Vertical
  * Increasing capacity of a single server
    * More CPU, more RAM, more Hard Drive
* Horizontal
  * Dividing the load over multiple servers
  * The trade off is increased complexity and maintenance for deployment
  * Sharding is Horizontal Scaling

## Sharding
Sharding is a method of distrubuting data across multiple machines. Used when there is a lot of 
data coming in quickly, which can reduce the ability of a single CPU / RAM / Hard Drive to handle 
the load. 

In order to implement a shard, the collection is data is partitioned using a shard key. This key
is an immutable field that excists on every item in the collection. Shard key should be as random
as possible so as to guarantee even spread of data load across all shards.

## Load Balancing
Each server has a finite amount of resources (network, CPU, Hard Drive etc). You do not want to have
all of your requests handled by a single server. 

If I need to increase the number of servers serving the traffic, I can just add more servers to the
load balancer.

Types of Load Balancers:
* Round Robin - just rotate blindly, almost like dealing cards for a card game
  * Does not take into account hardware differences
  * Does not take into account load on each server
  * Good when server specs are identical
* Weighted Round Robin - same as round robin, but each server is weighted
  * Node with the higher specs, it will be approtioned more requests
  * You assign weight beforehand
* Connection Based - least number of connections, and sends traffic there
  * Good when clients have variable connection lengths
* Weighted Connection Based - same as above, but with weights.
* Load Based - Based off CPU and Memory utilization
* Random - using some sort of Random Number Generator
  * Also good for clusters with similar configs

## Auto Scaling
The idea behind auto scaling is to increase and decrease the resourced assigned to a specific 
application based on the application load.  The hope is to use average CPU, Memory, Connections
within a certain safe range, while varying the number of machines assigned to a specific task based
off load.

Microservices lend themselves best to auto scaling, as each little part of the greater whole can
be scaled up and down depending on the load, without any waste on the scale up side for items which
may not need the additional resources, but are tied in to the same hardware as the process that does
need additional resources.

## Links
* https://docs.mongodb.com/manual/sharding/ - Sharding and Scaling in General - MongoDB
* https://www.youtube.com/watch?v=zHn2G71hoIk - Load Balancer
* https://www.youtube.com/watch?v=iqOTT7_7qXY - Load Balancing Algorithms