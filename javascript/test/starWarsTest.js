var StarWars = require('../src/starWars');
var assert = require('assert');

describe('StarWars doSomething', function() {
    it('should return 1', function() {
        var starWars = new StarWars();

        assert.equal(1, starWars.doSomething());
    })
});

