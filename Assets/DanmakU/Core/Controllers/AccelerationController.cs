// Copyright (c) 2015 James Liu
//	
// See the LISCENSE file for copying permission.

using UnityEngine;
using Vexe.Runtime.Types;

/// <summary>
/// A variety of useful 
/// </summary>
namespace DanmakU.Controllers {

	/// <summary>
	/// A Danmaku Controller that makes Danmaku speed up or slow down over time.
	/// </summary>
	public class AccelerationController : IDanmakuController {

		[SerializeField, Show]
		private float acceleration;
		public float Acceleration {
			get {
				return acceleration;
			}
			set {
				acceleration = value;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DanmakU.DanmakuControllers.AccelerationController"/> class.
		/// </summary>
		/// <param name="acceleration">Acceleration.</param>
		public AccelerationController (float acceleration = 0f) : base() {
			this.Acceleration = acceleration;
		}
		
		#region IDanmakuController implementation
		
		public virtual void Update (Danmaku danmaku, float dt) {
			if (Acceleration != 0) {
				danmaku.Speed += Acceleration * dt;
			}
		}
		
		#endregion
	}

}

