using System;
using Xunit;

namespace GameModel.Tests
{
    public class HeroTest
    {
        [Fact]
        public void IsAlive_HitPointsAreAboveZero_ShouldReturnTrue()
        {
            // Arrange
            var hero = new Hero {HitPoints = 5};

            // Act
            var hitPoints = hero.IsAlive();

            // Assert
            Assert.True(hitPoints);
            Assert.Equal(5, hero.HitPoints);
        }

        [Fact]
        public void IsAlive_HitPointsAreZero_ShouldReturnFalse()
        {
            // Arrange
            var hero = new Hero {HitPoints = 0};

            // Act
            var hitPoints = hero.IsAlive();
            
            // Assert
            Assert.False(hero.IsAlive());
            Assert.Equal(0, hero.HitPoints);
        }
        
        [Fact]
        public void IsAlive_HitPointsAreBelowZero_ShouldReturnFalse()
        {
            // Arrange
            var hero = new Hero {HitPoints = 0};

            // Act
            var hitpoints = hero.IsAlive();

            // Assert
            Assert.False(hero.IsAlive());
            Assert.Equal(0, hero.HitPoints);
            Assert.NotEqual(-1, hero.HitPoints);
        }

        [Fact]
        public void Attack_NotAlive_ShouldReturnZero()
        {
            // Arrange
            Hero hero = new Hero {Strength = 15, HitPoints = 0};

            // Act
            var attackPoints = hero.Attack();

            // Assert
            Assert.Equal(0, attackPoints);
        }

        [Fact]
        public void Attack_WithoutWeapon_ShouldReturnAttackValueFromStrengthOnly()
        {

        }

        [Fact]
        public void Attack_WithWeaponWithAttackOne_ShouldReturnAttackValue()
        {

        }

        [Fact]
        public void Attack_WithWeapon_ShouldReturnAttackValue()
        {

        }

        [Fact]
        public void Defend_WithDefenceZero_ShouldSubtractFromHitPoints()
        {

        }

        [Fact]
        public void Defend_WithDefenceAboveZero_ShouldSubtractFromHitpoints()
        {

        }

        [Fact]
        public void Defend_IsKilledFromAttack_HitPointsShouldNotGoBelowZero()
        {

        }

        [Fact]
        public void Defend_OpponentIsNull_ShouldThrowArgumentNullException()
        {

        }
    }
}
