#Star Wars
Design: 20 minutes  
Coding: 110 minutes


##Our client, an online retailer, wants to begin selling movies.

Since they have an existing system, they want us to build a new module for handling movie pricing and totals.

The online store should be able to call our service each time a movie is added to a customer's cart. When they're done adding movies, they should be able to get a total from our module.

To encourage sales of Star Wars movies, they want to discount purchases of multiple movies in the series.

##Here's what they've told us about the pricing and discounts:

One copy of any of the 6 movies costs $10.

If you buy two different episodes, you get a 5% discount on those two movies. Purchasing A New Hope and Empire Strikes Back, for example, would cost $19.

If you buy 3 different episodes, you get a 10% discount. So buying one copy of each of the prequels would total $27.

If you buy 4 different episodes, you get a 20% discount.

If you buy all 6 you get a 40% discount.

Note that if you buy four movies, of which 3 are different episodes, you get a 10% discount on the 3 distinct movies, but the fourth movie (the duplicate) still costs $10. See below.

Cart
----
1 copy of Episode IV: A New Hope  
2 copies of Episode V: The Empire Strikes Back  
1 copy of Episode VI: Return of the Jedi  

In this case, A New Hope, Return of the Jedi, and one copy of The Empire Strikes Back should be discounted 10%. The second copy of The Empire Strikes Back is full price.

So the total for this group of movies is $27 + $10 or $37.

We should always give the largest discount possible.