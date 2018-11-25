function realEstateAgency () {
	$('[name=regOffer]').on('click', () => {
		let apartmentRent = $('[name=apartmentRent]');
		let apartmentType = $('[name=apartmentType]');
		let agencyCommission = $('[name=agencyCommission]');

		if (apartmentRent.val() > 0 && agencyCommission.val() >= 0 && agencyCommission.val() <=100 && apartmentType.val() !== '' && apartmentType.val().indexOf(':') < 0) {
			let div = $('<div>');
			div.addClass('apartment');

			let p = $('<p>');
			p.text(`Rent: ${apartmentRent.val()}`);
			div.append(p);

			p = $('<p>');
			p.text(`Type: ${apartmentType.val()}`);
			div.append(p);

			p = $('<p>');
			p.text(`Commission: ${agencyCommission.val()}`);
			div.append(p);

			$('#building').append(div);

			$('#message').text('Your offer was created successfully.');

			apartmentRent.val('');
			apartmentType.val('');
			agencyCommission.val('');
			
		} else {
			$('#message').text('Your offer registration went wrong, try again.');

			apartmentRent.val('');
			apartmentType.val('');
			agencyCommission.val('');
		}

		apartmentRent.val('');
		apartmentType.val('');
		agencyCommission.val('');


	})

	$('[name=findOffer]').on('click', () => { 
		let familyBudget = $('[name=familyBudget]');
		let familyApartmentType = $('[name=familyApartmentType]');
		let familyName = $('[name=familyName]');

		let currentProfit;

		if (familyBudget.val() > 0 && familyApartmentType.val() !== '' && familyName !== '') {
			let building = $('.apartment');
			let apartment = $('.apartment').filter(a=> {
				let currentRent = +building[a].childNodes[0].textContent.split(': ')[1];
				let currentApartmentType = building[a].childNodes[1].textContent.split(': ')[1];
				let currentCommission = +building[a].childNodes[2].textContent.split(': ')[1];

				let totalPrice = currentRent + (currentCommission/100 * currentRent);

				currentProfit = totalPrice + (currentCommission/100 * currentRent);


				return currentApartmentType === familyApartmentType.val() && familyBudget.val() >= totalPrice;

			 })[0];

			 if (apartment === undefined) {
				$('#message').text('We were unable to find you a home, so sorry :(');

				familyBudget.val('');
				familyApartmentType.val('');
				familyName.val('');
				return;
			 }

			 apartment.lastChild.remove();
			 apartment.lastChild.remove();
			 apartment.lastChild.remove();

			let div = $('<div>');
			let p = $('<p>');
			p.text(`${familyName.val()}`);
			$(apartment).append(p);

			p = $('<p>');
			p.text('live here now');
			$(apartment).append(p);

			let button = $('<button>');
			button.text('MoveOut');
			button.on('click', ()=> {
				$('#message').text(`They had found cockroaches in ${familyName.val()}\'s apartment'`);
				$(apartment).remove();
			});

			button.appendTo($(apartment));
			
			$(apartment).attr('style', 'border: 2px solid red');

			let profit = +$('#roof')[0].childNodes[0].textContent.split(' ')[2] + currentProfit;
			 $('#roof h1').text(`Agency profit: ${profit} lv.`);



			$('#message').text('Enjoy your new home! :))');

			familyBudget.val('');
			familyApartmentType.val('');
			familyName.val('');


		} else {
			$('#message').text('We were unable to find you a home, so sorry :(');

			familyBudget.val('');
			familyApartmentType.val('');
			familyName.val('');
		}

		
	})
}