// Start
You see yourself in the distance.
* [< - >]
You arrive in front of a dead body.
** [< - >] -> A_1

=== A_1 === // Approach corpse
There is a resemblance of your image.
* [< Why? >]
    Dark skinned.
    ** [< - >]
    Disheveled white hair.
    *** [< - >]
    Tattered clothing.
    **** [< - >] -> A_11
* [< How did they die? >]
    You inspect the corpse.
    ** [< - >]
    The body is drained from life.
    *** [< - >]
    Their O Device is broken.
    **** [< - >]
    It seems that they suffocated to death.
    ***** [< - >] -> A_12
* [< (skip) >] -> A_2
    
=== A_11 === // [Why?] to corpse
You realize they are also Urdian.
* [< How did they die? >]
    You inspect the corpse.
    ** [< - >]
    The body is drained from life.
    *** [< - >]
    Their O Device is broken.
    **** [< - >]
    It seems that they suffocated to death.
    ***** [< - >] -> A_2
* [< (skip) >] -> A_2

=== A_12 === // [How did they die?] to corpse
There is a resemblance of your image.
* [< Why? >]
    Dark skinned.
    ** [< - >]
    Disheveled white hair.
    *** [< - >]
    Ragged clothing.
    **** [< - >]
    You realize they are also Urdian. 
    ***** [< - >] -> A_2
* [< (skip) >] -> A_2

=== A_2 ===
You think of your people back home.
** [< - >]
    Your throat tightens.
    *** [< Carry the corpse back to Urd >] -> A_3
        
=== A_3 === // [Carry corpse back to Urd.]
You carefully raise the corpse onto your back.
* [< - >]
The air reeks.
** [< - >]
The guant body presses against you.
*** [< - >]
You tread the barren path home.
**** [< - >] -> A_4
            
=== A_4 === // Urd

* [< - >]
You draw stares as you enter Urd.
** [< Report to Clan Leader >]
    You crouch to crawl into the Leader's hut. 
    *** [< - >]
    Your gaze meets his.
    **** [< - >]
    His face scrunches up as the odor permeates the place.
    ***** [< - >]
    "Verd?"
    ****** [< - >]
    "Is something the matter?"
    ******* [< - >]
    His sentence stops short at the corpse.
    ******** [< - >] -> A_41
** [< Look around >]
    You scan the village.
    *** [< - >]
    Your cousins are hunched near the clearing.
    **** [< - >]
    They hack feebly, rattling their bony figures.
    ***** [< - >]
    Pus froths from their necks.
    ****** [< - >]
    Your vision blurs.
    ******* [< Report to Clan Leader >] -> A_5
    
=== A_5 ===
You crouch to crawl into the Leader's hut. 
*** [< - >]
Your gaze meets his.
**** [< - >]
His face scrunches as odor permeates the place.
***** [< - >]
"Verd?"
****** [< - >]
"Is something the matter?"
******* [< - >]
His sentence stops short after the sight of the corpse.
******** [< - >] -> A_41
                        
=== A_41 ===
The Leader stands and moves briskly towards the entrance.
* [< - >]
He fumbles to close the straps.
** [< - >]
Collected, he sits back down and bores his eyes into yours.
*** [< - >]
"I know very well who this person was."
**** [< - >]
    "Verd... perhaps you've heard of the Prophecy?"
    ***** [< "I have not." >] -> A_42
    ***** [< "..." >] -> A_42

=== A_42 === // [I am.] to Leader
"Well if not..."
* [< - >]
"I hope for this tale to resonate well with you."
** [< - >]

*** [< - >]
-> END