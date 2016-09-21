function solve() {
    'use strict';

    const ERROR_MESSAGES = {
        INVALID_NAME_TYPE: 'Name must be string!',
        INVALID_NAME_LENGTH: 'Name must be between between 2 and 20 symbols long!',
        INVALID_NAME_SYMBOLS: 'Name can contain only latin symbols and whitespaces!',
        INVALID_MANA: 'Mana must be a positive integer number!',
        INVALID_EFFECT: 'Effect must be a function with 1 parameter!',
        INVALID_DAMAGE: 'Damage must be a positive number that is at most 100!',
        INVALID_HEALTH: 'Health must be a positive number that is at most 200!',
        INVALID_SPEED: 'Speed must be a positive number that is at most 100!',
        INVALID_COUNT: 'Count must be a positive integer number!',
        INVALID_SPELL_OBJECT: 'Passed objects must be Spell-like objects!',
        NOT_ENOUGH_MANA: 'Not enough mana!',
        TARGET_NOT_FOUND: 'Target not found!',
        INVALID_BATTLE_PARTICIPANT: 'Battle participants must be ArmyUnit-like!'
    };

    const validSymbols = /^[a-zA-Z ]+$/;
    const getId = (function() {
        let id = 0;

        return function() {
            id += 1;
            return id;
        };
    }());

    // your implementation goes here
    class Spell {
        constructor(name, manaCost, effect) {
            this.name = name;
            this.manaCost = manaCost;
            this.effect = effect;
        }

        get name() {
            return this._name;
        }
        set name(value) {
            if (typeof value !== "string") {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }
            if (value.length < 2 || value.length > 20) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_LENGTH);
            }
            if (!value.match(validSymbols)) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_SYMBOLS);
            }

            this._name = value;
        }

        get manaCost() {
            return this._manaCost;
        }
        set manaCost(value) {
            if (typeof value !== "number" || value <= 0) {
                throw new Error(ERROR_MESSAGES.INVALID_MANA);
            }

            this._manaCost = value;
        }

        get effect() {
            return this._effect;
        }
        set effect(value) {
            if (typeof value !== "function" || value.length !== 1) {
                throw new Error(ERROR_MESSAGES.INVALID_EFFECT);
            }

            this._effect = value;
        }

    }

    class Unit {
        constructor(name, alignment) {
            this.name = name;

        }

        get name() {
            return this._name;
        }
        set name(value) {
            if (typeof value !== "string") {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }
            if (value.length < 2 || value.length > 20) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_LENGTH);
            }
            if (!value.match(validSymbols)) {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_SYMBOLS);
            }

            this._name = value;
        }

        get alignment() {
            return this._alignment;
        }
        set alignment(value) {
            if (typeof value !== "string") {
                throw new Error(ERROR_MESSAGES.INVALID_NAME_TYPE);
            }

            if (value !== "good" && value !== "neutral" && value !== "evil") {
                throw new Error("Alignment must be good, neutral or evil!");
            }

            this._alignment = value;
        }
    }

    class ArmyUnit extends Unit {
        constructor(name, alignment, damage, health, count, speed) {
            super(name, alignment);
            this._id = getId();
            this.damage = damage;
            this.health = health;
            this.count = count;

        }

        get damage() {
            return this._damage;
        }
        set damage(value) {
            if (typeof value !== "number" || value < 0 || value > 100) {
                throw new Error(ERROR_MESSAGES.INVALID_DAMAGE);
            }

            this._damage = value;
        }

        get health() {
            return this._health;
        }
        set health(value) {
            if (typeof value !== "number" || value < 0 || value > 200) {
                throw new Error(ERROR_MESSAGES.INVALID_DAMAGE);
            }

            this._health = value;
        }

        get count() {
            return this._count;
        }
        set count(value) {
            if (typeof value !== "number" || value < 0) {
                throw new Error(ERROR_MESSAGES.INVALID_COUNT);
            }

            this._count = value;
        }

        get speed() {
            return this._speed;
        }
        set speed(value) {
            if (typeof value !== "number" || value < 0 || value > 100) {
                throw new Error(ERROR_MESSAGES.INVALID_SPEED);
            }

            this._speed = value;
        }
    }

    class Commander extends Unit {
        constructor(name, alignment, mana, spellbook, army) {
            super(name, alignment);
            this.mana = mana;
            this._spellbook = [];
            this._army = [];
        }
        get mana() {
            return this._mana;
        }
        set mana(value) {
            if (typeof value !== "number" || value < 0) {
                throw new Error(ERROR_MESSAGES.INVALID_MANA);
            }

            this._mana = value;
        }
    }

    // your implementation goes here

    const battlemanager = {
        battelCommanders: [],

        getCommander(name, alignment, mana) {
            return new Commander(name, alignment, mana);
        },

        getArmyUnit(options) {
            let name = options.name;
            let alignment = options.alignment;
            let damage = options.damage;
            let health = options.health;
            let count = options.count;
            let speed = options.speed;

            return new ArmyUnit(name, alignment, damage, health, count, speed);
        },

        getSpell(name, manaCost, effect) {
            return new Spell(name, manaCost, effect);
        },

        addCommanders(...commanders) {
            for (let commander of commanders) {
                this.battelCommanders.push(commander);
            }

            return this;
        },

        addArmyUnitTo(commanderName, armyUnit) {
            for (let commander of battelCommanders) {
                if (commanderName === commander.name) {
                    commander._army.push(armyUnit);
                }
            }
            return this;
        },

        addSpellsTo(commanderName, ...spells) {
            for (let commander of battelCommanders) {
                if (commanderName === commander.name) {
                    for (let spell in spells) {
                        if (spell instanceof Spell) {
                            commander._spellbook.push(spell);
                        } else {
                            throw new Error(ERROR_MESSAGES.INVALID_SPELL_OBJECT);
                        }
                    }
                }
            }
            return this;
        },

        findArmyUnitById(id) {
            let foundArmyUnit;

            for (let commander of battelCommanders) {
                if (commander.id === id) {
                    foundArmyUnit = commander;
                    break;
                }
                for (let unit of commander._army) {
                    if (unit.id === id) {
                        foundArmyUnit = unit;
                        break;
                    }
                }
            }

            return foundArmyUnit;
        }
    };

    return battlemanager;
}

module.exports = solve;