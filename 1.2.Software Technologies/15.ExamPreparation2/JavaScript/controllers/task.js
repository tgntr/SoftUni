const Task = require('../models/Task');

module.exports = {
	index: (req, res) => {
        Task.find().then(tasks => {
            res.render('task/index', {
                'openTasks': tasks.filter(t => t.status === "Open"),
                'inProgressTasks': tasks.filter(t => t.status === "In Progress"),
                'finishedTasks': tasks.filter(t => t.status === "Finished")
            });
        });
    },
	createGet: (req, res) => {
        res.render('task/create');
	},
	createPost: (req, res) => {
        let task = req.body;

        if (!task.title || !task.status) {
            res.render('task/create');
            return;
        }

        Task.create(task).then(task=> {
            res.redirect('/');
        });
	},
	editGet: (req, res) => {
        let id = req.params.id;

        if (!id) {
            res.redirect('/');
            return;
        }

        Task.findById(id).then(task=> {
            if (!task) {
                res.redirect('/');
                return;
            }

            res.render('task/edit', task);
        });
	},
	editPost: (req, res) => {
        let id = req.params.id;

        Task.findByIdAndUpdate(id, {title: req.body.title, status: req.body.status}).then(task=> {
            res.redirect('/');
        })	}
};