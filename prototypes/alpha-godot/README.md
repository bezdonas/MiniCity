Alpha prototype of the Mini city game

## Tech
Godot, C#

## Structure
Uses classic MVP where:
* **Model** interfaces and data classes. 
* **View** is everything that is directly connected to Godot.
They handle events and do everything godot-specific but any logic-heavy lifting is left for ...
* **Controllers** is separate abstract classes that control logic of the game. 