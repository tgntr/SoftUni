const Film = require('../models/Film');

module.exports = {
    index: (req, res) => {
        Film.find().then(films => {
            res.render('film/index', {'films': films});
        });
    },
    createGet: (req, res) => {
        res.render('film/create')
    },
    createPost: (req, res) => {
        let film = req.body;

        if (!film.name || !film.genre || !film.director || !film.year) {
            res.render('film/create');
            return;
        }

        Film.create(film).then(film => {
            res.redirect('/');
        });
    },
    editGet: (req, res) => {
        let id = req.params.id;

        if (!id) {
            res.redirect('/');
            return;
        }

        Film.findById(id).then(film=> {
            if (!film) {
                res.redirect('/');
                return;
            }

            res.render('film/edit', film);
        });    },
    editPost: (req, res) => {
        let id = req.params.id;

        Film.findByIdAndUpdate(id, {name: req.body.name, genre: req.body.genre, director: req.body.director, year: req.body.year}).then(film=> {
            res.redirect('/');
        })

    },
    deleteGet: (req, res) => {
        let id = req.params.id;

        if (!id) {
            res.redirect('/');
            return;
        }

        Film.findById(id).then(film => {
            if (!film) {
                res.redirect('/');
                return;
            }

            res.render('film/delete', film);
        });
    },
    deletePost: (req, res) => {
        let id = req.params.id;

        Film.findByIdAndRemove(id).then(film => {
            res.redirect('/');
        })
    }
};