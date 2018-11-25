function acceptance() {
    let shippingCompany = $('[name=shippingCompany]').val();
    let productName = $('[name=productName]').val();
	let productQuantity = $('[name=productQuantity]').val();
	let productScrape = $('[name=productScrape]').val();

	console.log(shippingCompany)

    if (shippingCompany !== '' && productName !== '' && productQuantity !== ''  && productScrape !== '' && productQuantity > 0 && productQuantity > productScrape) {
		let div = $('<div>');

		let p = $('<p>');
		p.text(`[${shippingCompany}] ${productName} - ${productQuantity-productScrape} pieces`)
		div.append(p);

		let button = $('<button>');
		button.attr('type', 'button');
		button.text('Out of stock');
		button.on('click', () => div.remove());
		div.append(button);

		$('#warehouse').append(div);

		$('input[name=shippingCompany]').val('');
    	$('input[name=productName]').val('');
		$('input[name=productQuantity]').val('');
		$('input[name=productScrape]').val('');
    }

}