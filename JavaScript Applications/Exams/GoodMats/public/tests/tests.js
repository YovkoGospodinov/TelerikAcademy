mocha.setup('bdd');

const expect = chai.expect;

describe("Test Controllers", function() {
    describe("Post Controller Tests", function() {
        describe("all Tests", function() {
            beforeEach(function() {
                sinon.stub(posts, 'postsGetAll')
                    .returns(Promise.resolve(data.result));

                sinon.stub(templates, 'get')
                    .returns(Promise.resolve(SOME_TEMPLATE));
            });

            afterEach(function() {
                posts.postsGetAll.restore();
                templates.get.restore();
            });

            it("expect posts.postsGetAll() to be called exactly once", function(done) {
                postController.all()
                    .then(() => {
                        expect(posts.postsGetAll.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });

            it("expect templates.get() to be called exactly once", function(done) {
                postController.all()
                    .then(() => {
                        expect(templates.get.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });
        });

        describe("allFromUser Tests", function() {
            beforeEach(function() {
                sinon.stub(posts, 'postsGetAll')
                    .returns(Promise.resolve(data.result));

                sinon.stub(templates, 'get')
                    .returns(Promise.resolve(SOME_TEMPLATE));
            });

            afterEach(function() {
                posts.postsGetAll.restore();
                templates.get.restore();
            });

            it("expect posts.postsGetAll() to be called exactly once if user has posts", function(done) {
                localStorage.authKey = SOME_POST.AuthorId;
                postController.allFromUser()
                    .then(() => {
                        console.log(localStorage.authKey);
                        console.log(SOME_POST.AuthorId);
                        expect(posts.postsGetAll.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });

            it("expect posts.postsGetAll() to be called exactly once if user has NO posts", function(done) {
                localStorage.authKey = SOME_POST.AuthorId + 1;
                postController.allFromUser()
                    .then(() => {
                        console.log(localStorage.authKey);
                        console.log(SOME_POST.AuthorId);
                        expect(posts.postsGetAll.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });

            it("expect templates.get() to be called exactly once if user has posts", function(done) {
                localStorage.authKey = SOME_POST.AuthorId;
                postController.allFromUser()
                    .then(() => {
                        expect(templates.get.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });

            it("expect templates.get() not to be called if user has NO posts", function(done) {
                localStorage.authKey = SOME_POST.AuthorId + 1;
                postController.allFromUser()
                    .then(() => {
                        expect(templates.get.callCount).to.equal(0);
                    })
                    .then(done, done);
            });
        });
    });

    describe("User Controller Tests", function() {
        describe("displayUser Tests", function() {
            beforeEach(function() {
                sinon.stub(users, 'getCurrentUser')
                    .returns(Promise.resolve(SOME_USER));

                sinon.stub(templates, 'get')
                    .returns(Promise.resolve(SOME_TEMPLATE));
            });

            afterEach(function() {
                users.getCurrentUser.restore();
                templates.get.restore();
            });

            it("expect users.getCurrentUser() to be called exactly once", function(done) {
                usersController.displayUser()
                    .then(() => {
                        expect(users.getCurrentUser.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });

            it("expect templates.get() to be called exactly once", function(done) {
                usersController.displayUser()
                    .then(() => {
                        expect(templates.get.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });
        });

        describe("getUserByUserName Tests", function() {
            beforeEach(function() {
                sinon.stub(users, 'userByUserName')
                    .returns(Promise.resolve(SOME_USER));

                sinon.stub(templates, 'get')
                    .returns(Promise.resolve(SOME_TEMPLATE));
            });

            afterEach(function() {
                users.userByUserName.restore();
                templates.get.restore();
            });

            it("expect users.userByUserName() to be called exactly once", function(done) {
                usersController.getUserByUserName()
                    .then(() => {
                        expect(users.userByUserName.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });

            it("expect templates.get() when user found to be called exactly once", function(done) {
                usersController.getUserByUserName()
                    .then(() => {
                        expect(templates.get.calledOnce).to.be.true;
                    })
                    .then(done, done);
            });
        });
    });
});

mocha.run();