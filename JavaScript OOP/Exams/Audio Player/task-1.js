function solve() {
    const getId = (function() {
        let id = 0;

        return function() {
            id += 1;
            return id;
        };
    }());

    const MIN_STRING_LENGTH = 3;
    const MAX_STRING_LENGTH = 25;

    class Validator {
        static validateString(input) {
            if (input === null) {
                throw new Error("Value can not be null.");
            }

            if (input === undefined || typeof input !== "string") {
                throw new Error("Value must be string");
            }

            if (input.length < MIN_STRING_LENGTH || input.length > MAX_STRING_LENGTH) {
                throw new Error("Value length must be between 3 and 25 characters.");
            }
        }

        static validateNumber(input) {
            if (input <= 0) {
                throw new Error("Value must be greater than 0.");
            }
        }
    }

    class Playable {
        constructor(title, author) {
            this._id = getId();
            this.title = title;
            this.author = author;
        }

        get id() {
            return this._id;
        }

        get title() {
            return this._title;
        }

        set title(value) {
            Validator.validateString(value);
            this._title = value;
        }

        get author() {
            return this._author;
        }

        set author(value) {
            Validator.validateString(value);
            this._author = value;
        }

        play() {
            return `${this._id}. ${this._title} - ${this._author}`;
        }
    }

    class Audio extends Playable {
        constructor(title, author, length) {
            super(title, author);
            this.length = length;
        }

        get length() {
            return this._length;
        }

        set length(value) {
            Validator.validateNumber(value);
            this._length = value;
        }

        play() {
            return super.play() + ` - ${this._length}`;
        }
    }

    class Video extends Playable {
        constructor(title, author, imdbRating) {
            super(title, author);
            this.imdbRating = imdbRating;
        }

        get imdbRating() {
            return this._imdbRating;
        }

        set imdbRating(value) {
            Validator.validateNumber(value);
            this._imdbRating = value;
        }

        play() {
            return super.play() + ` - ${this._imdbRating}`;
        }
    }

    function getPlayer(name) {
        // returns a new player instance with the provided name
    }

    function getPlaylist(name) {
        //returns a new playlist instance with the provided name
    }

    function getAudio(title, author, length) {
        //returns a new audio instance with the provided title, author and length
    }

    function getVideo(title, author, imdbRating) {
        //returns a new video instance with the provided title, author and imdbRating
    }

    return { getPlayer, getPlaylist, getAudio, getVideo };
}