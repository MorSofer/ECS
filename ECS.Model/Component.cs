﻿using System.Xml.Serialization;

namespace ECS.Model
{
    /// <summary>
    ///     A circuit component with 2 connections.
    /// </summary>
    public abstract class Component : DiagramObject
    {
        private Node _node1;
        private int? _node1Id;
        private Node _node2;
        private int? _node2Id;
        private double _rotation;

        [XmlIgnore]
        public Node Node1
        {
            get { return _node1; }
            set
            {
                _node1 = value;
                OnPropertyChanged();
            }
        }

        [XmlIgnore]
        public Node Node2
        {
            get { return _node2; }
            set
            {
                _node2 = value;
                OnPropertyChanged();
            }
        }

        [XmlElement]
        public int? Node1Id { get { return _node1?.Id ?? _node1Id; } set { _node1Id = value; } }

        [XmlElement]
        public int? Node2Id { get { return _node2?.Id ?? _node2Id; } set { _node2Id = value; } }

        [XmlAttribute]
        public double Rotation
        {
            get { return _rotation; }
            set
            {
                _rotation = value;
                OnPropertyChanged();
            }
        }
    }
}
