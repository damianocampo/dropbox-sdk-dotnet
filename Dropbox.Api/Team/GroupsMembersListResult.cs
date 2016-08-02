// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The groups members list result object</para>
    /// </summary>
    public class GroupsMembersListResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupsMembersListResult> Encoder = new GroupsMembersListResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupsMembersListResult> Decoder = new GroupsMembersListResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsMembersListResult" />
        /// class.</para>
        /// </summary>
        /// <param name="members">The members</param>
        /// <param name="cursor">Pass the cursor into <see
        /// cref="Dropbox.Api.Team.Routes.TeamRoutes.GroupsMembersListContinueAsync" /> to
        /// obtain additional group members.</param>
        /// <param name="hasMore">Is true if there are additional group members that have not
        /// been returned yet. An additional call to <see
        /// cref="Dropbox.Api.Team.Routes.TeamRoutes.GroupsMembersListContinueAsync" /> can
        /// retrieve them.</param>
        public GroupsMembersListResult(col.IEnumerable<GroupMemberInfo> members,
                                       string cursor,
                                       bool hasMore)
        {
            var membersList = enc.Util.ToList(members);

            if (members == null)
            {
                throw new sys.ArgumentNullException("members");
            }

            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.Members = membersList;
            this.Cursor = cursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupsMembersListResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GroupsMembersListResult()
        {
        }

        /// <summary>
        /// <para>Gets the members of the groups members list result</para>
        /// </summary>
        public col.IList<GroupMemberInfo> Members { get; protected set; }

        /// <summary>
        /// <para>Pass the cursor into <see
        /// cref="Dropbox.Api.Team.Routes.TeamRoutes.GroupsMembersListContinueAsync" /> to
        /// obtain additional group members.</para>
        /// </summary>
        public string Cursor { get; protected set; }

        /// <summary>
        /// <para>Is true if there are additional group members that have not been returned
        /// yet. An additional call to <see
        /// cref="Dropbox.Api.Team.Routes.TeamRoutes.GroupsMembersListContinueAsync" /> can
        /// retrieve them.</para>
        /// </summary>
        public bool HasMore { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupsMembersListResult" />.</para>
        /// </summary>
        private class GroupsMembersListResultEncoder : enc.StructEncoder<GroupsMembersListResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupsMembersListResult value, enc.IJsonWriter writer)
            {
                WriteListProperty("members", value.Members, writer, Dropbox.Api.Team.GroupMemberInfo.Encoder);
                WriteProperty("cursor", value.Cursor, writer, enc.StringEncoder.Instance);
                WriteProperty("has_more", value.HasMore, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupsMembersListResult" />.</para>
        /// </summary>
        private class GroupsMembersListResultDecoder : enc.StructDecoder<GroupsMembersListResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupsMembersListResult"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupsMembersListResult Create()
            {
                return new GroupsMembersListResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupsMembersListResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "members":
                        value.Members = ReadList<GroupMemberInfo>(reader, Dropbox.Api.Team.GroupMemberInfo.Decoder);
                        break;
                    case "cursor":
                        value.Cursor = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "has_more":
                        value.HasMore = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}