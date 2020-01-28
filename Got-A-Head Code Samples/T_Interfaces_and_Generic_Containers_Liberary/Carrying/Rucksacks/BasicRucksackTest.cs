using Interfaces_and_Generic_Containers.Example1_Interfaces;
using Xunit;
using XUnitUtils;
using ArmouryObjects.RucksackItems;
using ArmouryObjects.Carrying.Rucksacks.Pocket;
using ArmouryObjects.Carrying.Rucksacks;
using ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment;

namespace T_Interfaces_and_Generic_Containers_Liberary.Carrying.Rucksacks
{
    public class BasicRucksackTest
    {
        const float _mainPocketHeight = 0.8f;
        const float _mainPocketWidth = 0.5f;
        const float _mainPocketDepth = 0.4f;
        const float _mainPocketVolume = 0.16f;
        const float _mainPocketMass = 80f;
        const int _depthCheckProportion = 4;

        const float _rucksackHeight = 0.8f;
        const float _rucksackWidth = 0.5f;
        const float _rucksackDepth = 0.03f;
        const float _rucksackVolume = 0f;
        const float _rucksackMass = 0.5f;

        const float _rucksackDefaultDepth = 0.07f;
        const float _rucksackDefaultVolume = 0f;
        const float _rucksackDefaultMass = 0.5f;


        const float _topPocketDepth = _mainPocketHeight / _depthCheckProportion;
        const float _topPocketHeight = _mainPocketDepth;
        const float _topPocketWidth = _mainPocketWidth;
        const float _topPocketMass = _mainPocketMass / 8;
        /// <summary>
        /// 
        /// </summary>
        public BasicRucksackTest()
        {

        }


        [Fact]
        public void CanCreateRucksack()
        {
            IRucksackPocket mainPocket = new RucksackPocket<SizeAndDepthRules>(
                _mainPocketHeight,
                _mainPocketWidth,
                _mainPocketDepth,
                _mainPocketVolume,
                _mainPocketMass,
                _depthCheckProportion);
            IRucksack rucksackFixture = new Rucksack(
                _rucksackHeight,
                _rucksackWidth,
                mainPocket
                );

            Assert.Equal(_mainPocketWidth, rucksackFixture.MainPocket.Width);
            Assert.Equal(_mainPocketHeight, rucksackFixture.MainPocket.Height);
            Assert.Equal(_mainPocketDepth, rucksackFixture.MainPocket.Depth);
            Assert.Equal(_mainPocketMass, rucksackFixture.MainPocket.Mass);
            Assert.Equal(_depthCheckProportion, rucksackFixture.MainPocket.AttachedPocketDepthPreporation);

            Assert.Equal(_rucksackWidth, rucksackFixture.Width);
            Assert.Equal(_rucksackHeight, rucksackFixture.Height); 
            Assert.Equal(Rucksack.DefaultDepth, rucksackFixture.Depth);
            Assert.Equal(Rucksack.DefaultMass, rucksackFixture.Mass);
            Assert.Equal(_rucksackHeight * _rucksackWidth * Rucksack.DefaultDepth, rucksackFixture.Volume);

        }



        [Fact]
        public void CanAddTopPocket()
        {
            IRucksackPocket mainPocket = new RucksackPocket<SizeAndDepthRules>(
                _mainPocketHeight,
                _mainPocketWidth,
                _mainPocketDepth,
                _mainPocketVolume,
                _mainPocketMass,
                _depthCheckProportion);
            IRucksack rucksackFixture = new Rucksack(
                _rucksackHeight,
                _rucksackWidth,
                mainPocket
                );

            IRucksackPocket newTopPocket = new RucksackPocket<SizeAndDepthRules>(
                                                 _topPocketHeight,
                                                 _topPocketWidth,
                                                 _topPocketDepth,
                                                 _topPocketMass
                                                 );

            Assert.True(rucksackFixture.MainPocket.Top.CanPocketFitOnFace(newTopPocket));
        }


    }
}
