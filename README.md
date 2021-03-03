# FactoryDesignPattern

- FACTORY DESIGN PATTERN
	- way to create an object via interface
	- Factory will always return Interface
	
- Example
	- there need to exist a factory which produces products with different behaviour
	- so consider a factory of cards, card factory should give different cards which may differ in there behaviour bt end product should be card
	- Consider
	- Card
		|	- SilverCard 
		|	- GoldCard
		|	- PlatinumCard
	- interfacing Card, we would have ICard --> { bool DoesCardExists(int id) } && --> { Card CreateCard(int id) }
		SilverCard : ICard
			//silver card may have different business for CreateCard() and DoesCardExists() 
		GoldCard : ICard
			//gold card may have different business for CreateCard() and DoesCardExists() 
		PlatinumCard : ICard
			//platinum card may have different business for CreateCard() and DoesCardExists() 
			
		- but all will at the end return a Card when card is created
		- and true/false when DoesCardExists()
	- Now lets have a Factory,ICardFactory --> { ICard GetCard() }
		CardFactory:ICardFactory
		// GetCard will decide based on its business logic if it wants to return SilverCard/GoldCard/PlatinumCard of type ICard
		// i,e CardFactory:ICardFactory{
			ICard GetCard(){
				return new SilverCard();
			}
		}
					
	- In short, a factory will always return an object of IProduct, and based on behaviour of IProduct we can exicute business
	
- advantage
	- if i want to and another product say, diamondCard i can easily add so without any change in design and hirerchy
	- You avoid tight coupling between the creator of object and the concrete products(Card).
	- Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
	- Open/Closed Principle. You can introduce new types of products into the program without breaking existing client code.
	
		
