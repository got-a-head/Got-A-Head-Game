using ArmouryObjects.RucksackItems;
using System;
using ArmouryObjects.Carrying.Rucksacks.Pocket.Face;
using ArmouryObjects.Carrying.Rucksacks.Pocket.Attachment;
using System.Collections.Generic;

namespace ArmouryObjects.Carrying.Rucksacks.Pocket
{
    /// <summary>
    /// 
    /// </summary>
    public class RucksackPocket<TAttachment> : RucksackItem, IRucksackPocket
        where TAttachment : IPocketAttachment, new()
    {
        const int DefaultAttachedPockettDepthPreporation = 6;

        int _attachedPocketDepthPreporation;
        TAttachment _attachmentLogic;
        List<IRucksackPocket> _topPockets;
        List<IRucksackPocket> _bottomPockets;
        List<IRucksackPocket> _leftPockets;
        List<IRucksackPocket> _rightPockets;
        List<IRucksackPocket> _frontPockets;

        IRucksackPocketFace _top;
        IRucksackPocketFace _bottom;
        IRucksackPocketFace _left;
        IRucksackPocketFace _right;
        IRucksackPocketFace _back;
        IRucksackPocketFace _front;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <param name="volume"></param>
        /// <param name="mass"></param>
        /// <param name="attachedPocketDepthPreporation"></param>
        public RucksackPocket(float height, float width, float depth, float volume, float mass, int attachedPocketDepthPreportion = DefaultAttachedPockettDepthPreporation) : base(height, width, depth, volume, mass)
        {
            _attachmentLogic = new TAttachment();
            _topPockets = new List<IRucksackPocket> ();
            _bottomPockets = new List<IRucksackPocket>();
            _leftPockets = new List<IRucksackPocket>();
            _rightPockets = new List<IRucksackPocket>();
            _frontPockets = new List<IRucksackPocket>();
            _attachedPocketDepthPreporation = attachedPocketDepthPreportion;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="depth"></param>
        /// <param name="mass"></param>
        /// <param name="attachedPocketDepthPreporation"></param>
        public RucksackPocket(float height, float width, float depth, float mass, int attachedPocketDepthPreportion = DefaultAttachedPockettDepthPreporation) : base(height, width, depth, height * width * depth, mass)
        {
            _attachmentLogic = new TAttachment();
            _topPockets = new List<IRucksackPocket>();
            _bottomPockets = new List<IRucksackPocket>();
            _leftPockets = new List<IRucksackPocket>();
            _rightPockets = new List<IRucksackPocket>();
            _frontPockets = new List<IRucksackPocket>();
            _attachedPocketDepthPreporation = attachedPocketDepthPreportion;
        }

        /// <summary>
        /// 
        /// </summary>
        public IRucksackPocketFace Top { get { return _top is null ? _top = new TopFace(this) : _top ; }  }

        /// <summary>
        /// 
        /// </summary>
        public IRucksackPocketFace Bottom { get { return _bottom is null ? _bottom = new BottomFace(this) : _bottom; } }

        /// <summary>
        /// 
        /// </summary>
        public IRucksackPocketFace Back { get { return _back is null ? _back = new BackFace(this) : _back; } }

        /// <summary>
        /// 
        /// </summary>
        public IRucksackPocketFace Front { get { return _front is null ? _front = new FrontFace(this) : _front; } }

        /// <summary>
        /// 
        /// </summary>
        public IRucksackPocketFace Left { get { return _left is null ? _left = new LeftFace(this) : _left; } }

        /// <summary>
        /// 
        /// </summary>
        public IRucksackPocketFace Right { get { return _right is null ? _right = new RightFace(this) : _right; } }

        /// <summary>
        /// 
        /// </summary>
        public IList<IRucksackPocket> TopPockets
        {
            get { return _topPockets.AsReadOnly();  }
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<IRucksackPocket> BottomPockets
        {
            get { return _bottomPockets.AsReadOnly(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<IRucksackPocket> LeftPockets
        {
            get { return _leftPockets.AsReadOnly(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<IRucksackPocket> RightPockets
        {
            get { return _rightPockets.AsReadOnly(); }
        }

        /// <summary>
        /// 
        /// </summary>
        public IList<IRucksackPocket> FrontPockets
        {
            get { return _frontPockets.AsReadOnly(); }
        }
        /// <summary>
        /// 
        /// </summary>
        public int AttachedPocketDepthPreporation
        {
            get { return _attachedPocketDepthPreporation; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="face"></param>
        /// <param name="newPockt"></param>
        /// <returns></returns>
        public bool CanPocketFitOnFace(IRucksackPocketFace face, IRucksackPocket newPockt)
        {
            return _attachmentLogic.CanPockeAttachToParent(face, newPockt);
        }
    }
}
