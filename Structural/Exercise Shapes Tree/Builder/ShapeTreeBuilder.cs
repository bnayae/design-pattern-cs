using Autofac.Features.Indexed;

namespace Bnaya.Samples
{
    public class ShapeTreeBuilder : IShapeTreeBuilder, IShapeBuilderFactory
    {
        private readonly IIndex<Keys, IShape> _mapper;
        private readonly ShapeNextChildren _data;

        public ShapeTreeBuilder(IIndex<Keys, IShape> mapper)
        {
            _mapper = mapper;
            _data = new ShapeNextChildren(Keys.Empty, NullShape.Default);
        }
        private ShapeTreeBuilder(ShapeNextChildren data, IIndex<Keys, IShape> mapper)
        {
            _mapper = mapper;
            _data = data;
        }


        public IShapeTreeBuilder Create(Keys key)
        {
            IShape shape = _mapper[key];
            ShapeNextChildren immutableNode = new ShapeNextChildren(key, shape);
            return new ShapeTreeBuilder(immutableNode, _mapper);
        }
        public IShapeTreeBuilder AddChild(Keys key)
        {
            IShape child = _mapper[key];
            ShapeNextChildren immutableNode = _data.AddChild(key, child);
            return new ShapeTreeBuilder(immutableNode, _mapper);
        }

        public IShapeTreeBuilder AddNext(Keys key)
        {
            IShape next = _mapper[key];
            ShapeNextChildren immutableNode = _data.SetNext(key, next);
            return new ShapeTreeBuilder(immutableNode, _mapper);
        }

        public IShape Build() => _data;

    }
}