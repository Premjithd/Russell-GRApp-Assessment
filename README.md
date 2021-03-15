# GR Application

Hi and welcome to GR. We also buy and sell only the finest goods. 
Unfortunately, our goods are constantly degrading in quality as they approach
their sell by date. We have a system in place that updates our inventory for
us.

First an introduction to our system:

- All items have a SellIn value which denotes the number of days we have 
to sell the item
- All items have a Quality value which denotes how valuable the item is
- At the end of each day our system lowers both values for every item

This is where it gets interesting:

- Once the sell by date has passed, Quality degrades twice as fast
- The Quality of an item is never negative
- "Aged Brie" actually increases in Quality the older it gets
- The Quality of an item is never more than 50
- "Sulfuras", being a legendary item, never has to be sold or decreases 
in Quality
- "Backstage passes", like aged brie, increases in Quality as it's SellIn 
value approaches; Quality increases by 2 when there are 10 days or less 
and by 3 when there are 5 days or less but Quality drops to 0 after the 
concert

# Challenge

We have recently signed a supplier of conjured items. This requires an 
update to our system:

- "Conjured" items degrade in Quality twice as fast as normal items

Users have also reported that there are some bugs with the system.

- "Backstage passes" do not seem to be increasing in Quality per the
  specifications as the concert gets closer.
- "Backstage passes" do not reduce to a Quality of 0 after the concert passes.

Feel free to make any changes to the UpdateInventory method and add any 
new code as long as everything still works correctly.

Just for clarification, an item can never have its Quality increase 
above 50, however "Sulfuras" is a legendary item and as such its 
Quality is 80 and it never alters.
