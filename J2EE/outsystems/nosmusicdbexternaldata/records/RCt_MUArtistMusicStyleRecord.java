package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_MUArtistMusicStyleRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUArtistMusicStyleRecord> {

	private static final GlobalObjectKey Idt_MUArtistMusicStyle = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*_9gx9xkpKa0TrZ8htnA9Mg");

	public static void ensureInitialized() {}
	public ENt_MUArtistMusicStyleEntityRecord ssENt_MUArtistMusicStyle;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUArtistMusicStyleEntityRecord toStructure() {
		return ssENt_MUArtistMusicStyle;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUArtistMusicStyleRecord(ENt_MUArtistMusicStyleEntityRecord r) throws Exception {
		ssENt_MUArtistMusicStyle = (ENt_MUArtistMusicStyleEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUArtistMusicStyle.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUArtistMusicStyle.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUArtistMusicStyleRecord() {
		OptimizedAttributes = null;
		ssENt_MUArtistMusicStyle = new ENt_MUArtistMusicStyleEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(4, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUArtistMusicStyle.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUArtistMusicStyle.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUArtistMusicStyle.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_MUArtistMusicStyle.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_MUArtistMusicStyleRecord r) throws Exception {
		this.ssENt_MUArtistMusicStyle = (ENt_MUArtistMusicStyleEntityRecord) r.ssENt_MUArtistMusicStyle.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_MUArtistMusicStyleRecord)) {
			return false;
		}
		RCt_MUArtistMusicStyleRecord b = (RCt_MUArtistMusicStyleRecord) obj;
		if (!this.ssENt_MUArtistMusicStyle.equals(b.ssENt_MUArtistMusicStyle)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_MUArtistMusicStyle.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUArtistMusicStyle.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUArtistMusicStyle.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUArtistMusicStyleRecord duplicate() throws Exception {
		RCt_MUArtistMusicStyleRecord t = new RCt_MUArtistMusicStyleRecord();
		t.ssENt_MUArtistMusicStyle = (ENt_MUArtistMusicStyleEntityRecord) this.ssENt_MUArtistMusicStyle.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_MUArtistMusicStyle.toXml(this, recordElem, "t_MUArtistMusicStyle", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_muartistmusicstyle")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUArtistMusicStyle")) variable.setValue(ssENt_MUArtistMusicStyle); else variable.setOptimized(true);
			variable.setFieldName("t_muartistmusicstyle");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUArtistMusicStyleRecord t = (RCt_MUArtistMusicStyleRecord) super.clone();
		t.ssENt_MUArtistMusicStyle = (ENt_MUArtistMusicStyleEntityRecord) this.ssENt_MUArtistMusicStyle.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistMusicStyle.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUArtistMusicStyle.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUArtistMusicStyle)) {
			return ssENt_MUArtistMusicStyle;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUArtistMusicStyle.fillFromOther((IRecord) other.attributeGet(Idt_MUArtistMusicStyle));
	}
}
