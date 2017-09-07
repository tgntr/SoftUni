const Product = require('../models/Product');

module.exports = {
	index: (req, res) => {
        Product.find().then(products => {
            res.render('product/index', {'entries': products});
        });
    },
	createGet: (req, res) => {
        res.render('product/create')
	},
	createPost: (req, res) => {
        let product = req.body;

        if (!product.priority || !product.name || !product.quantity) {
            res.render('product/create');
            return;
        }

        Product.create(product).then(product => {
            res.redirect('/');
        });
    },
	editGet: (req, res) => {
        let id = req.params.id;

        if (!id) {
            res.redirect('/');
            return;
        }

        Product.findById(id).then(product => {
            if (!product) {
                res.redirect('/');
                return;
            }

            res.render('product/edit', product);
        });
    },
	editPost: (req, res) => {
        let id = req.params.id;

        Product.findByIdAndUpdate(id, {priority: req.body.priority, name: req.body.name, quantity: req.body.quantity, status: req.body.status}).then(product=> {
            res.redirect('/');
        })	}
};