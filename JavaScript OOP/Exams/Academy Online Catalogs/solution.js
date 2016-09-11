function solve() {

    const getId = (function() {
        let id = 0;

        return function() {
            id += 1;
            return id;
        };
    }());

    const MIN_STRING_LENGTH = 2;
    const MAX_STRING_LENGTH = 40;

    class Validator {
        static stringEmptyValidator(input) {
            if (typeof input !== "string" || input === null || input === undefined || input.length === 0) {
                throw new Error("String can not be empty or null.");
            }
        }

        static stringLengthValidator(input) {
            if (input.length < MIN_STRING_LENGTH || input.length > MAX_STRING_LENGTH) {
                throw new Error(`String length must be between ${MIN_STRING_LENGTH} and ${MAX_STRING_LENGTH} symbols long.`);
            }
        }

        static validateDuration(input) {
            if (input <= 0 || typeof input !== "number") {
                throw new Error("Duration must be greater than 0.");
            }
        }

        static validateRating(input) {
            if (input < 1 || input > 5 || typeof input !== "number") {
                throw new Error("Rating must be between 1 and 5 symbols long.");
            }
        }

        static validateIsbn(input) {
            if (input.length !== 10 && input.length !== 13) {
                throw new Error("Isbn must be between exactly 10 or 13 symbols long.");
            }
        }

        static validateGenre(input) {
            if (input.length < 2 || input.length > 20) {
                throw new Error("Genre must be between 2 and 20 symbols long.");
            }
        }
    }

    class Item {
        constructor(name, description) {
            this._id = getId();
            this.description = description;
            this.name = name;
        }

        get id() {
            return this._id;
        }

        get description() {
            return this._description;
        }

        set description(value) {
            Validator.stringEmptyValidator(value);
            this._description = value;
        }

        get name() {
            return this._name;
        }

        set name(value) {
            Validator.stringLengthValidator(value);
            this._name = value;
        }
    }

    class Media extends Item {
        constructor(name, rating, duration, description) {
            super(name, description);
            this.duration = duration;
            this.rating = rating;
        }

        get duration() {
            return this._duration;
        }

        set duration(value) {
            Validator.validateDuration(value);
            this._duration = value;
        }

        get rating() {
            return this._rating;
        }

        set rating(value) {
            Validator.validateRating(value);
            this._rating = value;
        }
    }

    class Book extends Item {
        constructor(name, isbn, genre, description) {
            super(name, description);
            this.isbn = isbn;
            this.genre = genre;
        }

        get isbn() {
            return this._isbn;
        }

        set isbn(value) {
            Validator.stringEmptyValidator(value);
            Validator.validateIsbn(value);
            this._isbn = value;
        }

        get genre() {
            return this._genre;
        }

        set genre(value) {
            Validator.validateGenre(value);
            this._genre = value;
        }
    }

    function getBook(name, isbn, genre, description) {
        return new Book(name, isbn, genre, description);
    }

    function getMedia(name, rating, duration, description) {
        return new Media(name, rating, duration, description);
    }

    function getBookCatalog(name) {
        // return a book catalog instance
    }

    function getMediaCatalog(name) {
        // return a media catalog instance
    }


    return { getBook, getMedia, getBookCatalog, getMediaCatalog };
}

module.exports = solve;