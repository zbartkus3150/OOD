using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ToyDecorator : IToy
    {
        public IToy _toy;

        public ToyDecorator(IToy toy)
        {
            _toy = toy;
        }
        public virtual float Cost()
        {
            return _toy.Cost();
        }

        public virtual string Summary()
        {
            return _toy.Summary();
        }

        public virtual float Height()
        {
            return _toy.Height();
        }
    }

    class SwordDecorator : ToyDecorator
    {
        public SwordDecorator(IToy toy)
            : base(toy)
        {

        }

        public override float Cost()
        {
            return base.Cost() + 15;
        }

        public override string Summary()
        {
            return base.Summary() + "I have a sword! ";
        }
    }

    class HelmetDecorator : ToyDecorator
    {
        public HelmetDecorator(IToy toy)
            : base(toy)
        {

        }

        public override float Cost()
        {
            return base.Cost() + 10;
        }

        public override string Summary()
        {
            return base.Summary() + "I have a helmet on my head! ";
        }
    }

    class DressDecorator : ToyDecorator
    {
        bool type;
        public DressDecorator(IToy toy, bool _type)
            : base(toy)
        {
            type = _type;
        }

        public override float Cost()
        {
            if (type == true)
                return base.Cost() + 20;
            else
                return base.Cost() + (float)19.99;
        }

        public override string Summary()
        {
            if (type == true)
                return base.Summary() + "I have a flower dress ";
            else
                return base.Summary() + "I have a dotted dress ";
        }
    }

    class JumpDecorator : ToyDecorator
    {
        public int jump_modifier = 5;
        public JumpDecorator(IToy toy)
            : base(toy)
        {

        }

        public override float Cost()
        {
            return base.Cost() + 20;
        }

        public override string Summary()
        {
            if (jump_modifier >= 1)
            {
                float jump_height = base.Height() * (jump_modifier--) / 10;
                return base.Summary() + "I can jump! I just jumped " + jump_height + "cm! ";
            }
            else
                return base.Summary();
        }
    }

    class DanceDecorator : ToyDecorator
    {
        string type;
        public DanceDecorator(IToy toy, string _type)
            : base(toy)
        {
            type = _type;
        }

        public override float Cost()
        {
            if (type == "breakdance")
                return base.Cost() + 50;
            else if (type == "solo capoeira")
                return base.Cost() + 70;
            else if (type == "gangnam style dance")
                return base.Cost() + 100;
            else
                return base.Cost();
        }

        public override string Summary()
        {
            if (type == "breakdance" || type == "solo capoeira" || type == "gangnam style dance")
                return base.Summary() + "I can dance <" + type + "> ";
            else
                return base.Summary();
        }
    }

    class StorytellingDecorator : ToyDecorator
    {
        bool type;
        public StorytellingDecorator(IToy toy, bool _type)
            : base(toy)
        {
            type = _type;
        }

        public override float Cost()
        {
            return base.Cost() + 30;
        }

        public override string Summary()
        {
            if (type == true)
                return base.Summary() + "I tell scary stories ";
            else
                return base.Summary() + "I tell really funny jokes! ";
        }
    }
}
